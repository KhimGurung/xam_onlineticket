using System;
using CoreGraphics;
using UIKit;
using xam_onlineticket.CustomControls;
using xam_onlineticket.iOS.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

[assembly: ExportRenderer(typeof(CustomNavigationPage), typeof(CustomNavigationPageRenderer))]
namespace xam_onlineticket.iOS.CustomRenderers
{
    public class CustomNavigationPageRenderer : NavigationRenderer
    {
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            if (Element is Xamarin.Forms.NavigationPage navigationPage)
            {
                if (navigationPage.OnThisPlatform().HideNavigationBarSeparator())
                {
                    //NavigationBar.SetBackgroundImage(new UIImage(), UIBarMetrics.Default);
                    //NavigationBar.ShadowImage = new UIImage();
                    if (UIDevice.CurrentDevice.CheckSystemVersion(13, 0))
                    {
                        NavigationBar.StandardAppearance.ShadowColor = null;
                        //NavigationBar.ScrollEdgeAppearance.ShadowColor = null;
                    }
                }
            }
        }
    }
}

