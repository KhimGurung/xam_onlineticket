using System;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace xam_onlineticket.CustomControls
{
    public class CustomNavigationPage : Xamarin.Forms.NavigationPage
    {
        public CustomNavigationPage() : base(){}

        public CustomNavigationPage(Xamarin.Forms.Page page) : base(page)
        {
            On<iOS>().SetHideNavigationBarSeparator(true);
        }
    }
}

