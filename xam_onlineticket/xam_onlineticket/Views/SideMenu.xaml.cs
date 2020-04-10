using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using xam_onlineticket.CustomControls;
using xam_onlineticket.Models;
using xam_onlineticket.Views;
using Xamarin.Forms;

namespace xam_onlineticket
{
    public partial class SideMenu : CustomMasterDetailPage
    {
        Dictionary<int, CustomNavigationPage> MenuPages = new Dictionary<int, CustomNavigationPage>();
        public SideMenu()
        {
            InitializeComponent();

            this.MasterBehavior = MasterBehavior.Popover;

            CustomNavigationPage currentDetailPage = (CustomNavigationPage)Detail;
            currentDetailPage.BarBackgroundColor = (Color)App.Current.Resources["PrimaryBackgroundColor"];
            currentDetailPage.BarTextColor = (Color)App.Current.Resources["PrimaryTextColor"];

            MenuPages.Add((int)MenuItemType.TicketListPage, currentDetailPage);
        }

        public async Task NavigatePage(int id)
        {
            IsPresented = false;

            if (Device.RuntimePlatform == Device.Android)
            {
                await Task.Delay(200);
            }

            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.TicketListPage:
                        MenuPages.Add(id, new CustomNavigationPage(new TicketListPage()));
                        break;
                    case (int)MenuItemType.AboutUsPage:
                        MenuPages.Add(id, new CustomNavigationPage(new AboutUsPage()));
                        break;
                    case (int)MenuItemType.BuyTicketPage:
                        MenuPages.Add(id, new CustomNavigationPage(new BuyTicketPage()));
                        break;
                    case (int)MenuItemType.SettingPage:
                        MenuPages.Add(id, new CustomNavigationPage(new SettingPage()));
                        break;
                    case (int)MenuItemType.Logout:
                        App.Current.MainPage = new LoginPage();
                        return;
                }
            }

            var selectedPage = MenuPages[id];

            if(selectedPage != null && Detail != selectedPage)
            {
                selectedPage.BarBackgroundColor = (Color)App.Current.Resources["PrimaryBackgroundColor"];
                selectedPage.BarTextColor = (Color)App.Current.Resources["PrimaryTextColor"];

                Detail = selectedPage;
                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);
            }
        }
    }
}
