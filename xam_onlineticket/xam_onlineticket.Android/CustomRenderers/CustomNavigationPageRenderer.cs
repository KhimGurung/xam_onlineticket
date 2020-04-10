using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Plugin.CurrentActivity;
using xam_onlineticket.CustomControls;
using xam_onlineticket.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(CustomNavigationPage), typeof(CustomNavigationPageRenderer))]
namespace xam_onlineticket.Droid.CustomRenderers
{
    public class CustomNavigationPageRenderer : NavigationPageRenderer
    {

        public CustomNavigationPageRenderer(Context context) : base(context) { }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            base.OnLayout(changed, l, t, r, b);
        }

        protected override Task<bool> OnPushAsync(Page view, bool animated)
        {
            var retVal = base.OnPushAsync(view, animated);

            GlobalSetting.NavigationStackCount = view.Navigation.NavigationStack.Count;

            return retVal;
        }

        protected override Task<bool> OnPopToRootAsync(Page page, bool animated)
        {
            var retVal = base.OnPopToRootAsync(page, animated);

            GlobalSetting.NavigationStackCount = page.Navigation.NavigationStack.Count - 1;

            return retVal;
        }

        protected override Task<bool> OnPopViewAsync(Page page, bool animated)
        {
            var retVal = base.OnPopViewAsync(page, animated);

            GlobalSetting.NavigationStackCount = page.Navigation.NavigationStack.Count - 1;

            return retVal;
        }
    }
}

