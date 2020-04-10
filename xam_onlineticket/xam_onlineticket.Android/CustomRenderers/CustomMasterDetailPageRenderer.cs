using System;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Plugin.CurrentActivity;
using Xamarin.Forms;
using xam_onlineticket.CustomControls;
using xam_onlineticket.Droid.CustomRenderers;
using Xamarin.Forms.Platform.Android.AppCompat;
using Android.Runtime;

[assembly: ExportRenderer(typeof(CustomMasterDetailPage), typeof(CustomMasterDetailPageRenderer))]
namespace xam_onlineticket.Droid.CustomRenderers
{
    public class CustomMasterDetailPageRenderer : MasterDetailPageRenderer
    {
        private static Android.Support.V7.Widget.Toolbar GetToolbar() => (CrossCurrentActivity.Current?.Activity as MainActivity)?.FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);

        private Android.Support.V7.Widget.Toolbar toolbar;

        public CustomMasterDetailPageRenderer(Context context) : base(context) { }

        [Obsolete]
        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            base.OnLayout(changed, l, t, r, b);
            toolbar = GetToolbar();

            if (toolbar != null)
            {
                if (GlobalSetting.NavigationStackCount == 1)
                {
                    SetNavigationButton(Resource.Drawable.menu);
                }
                else
                {
                    SetNavigationButton(Resource.Drawable.back);
                }
            }
        }

        [Obsolete]
        private void SetNavigationButton(int resourceID)
        {
            var icon = Forms.Context.GetDrawable(resourceID);
            using (var drawable = ((BitmapDrawable)icon).Bitmap)
            using (var bitmap = Bitmap.CreateScaledBitmap(drawable, 26, 26 , false))
            using (var newDrawable = new BitmapDrawable(Resources, bitmap))
            {
                toolbar.NavigationIcon = newDrawable;
            }
        }

    }
}

