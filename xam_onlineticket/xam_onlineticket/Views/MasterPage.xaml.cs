using System;
using System.Collections.Generic;
using xam_onlineticket.Helpers;
using xam_onlineticket.Models;
using Xamarin.Forms;

namespace xam_onlineticket.Views
{
    public partial class MasterPage : ContentPage
    {
        SideMenu RootPage { get => Application.Current.MainPage as SideMenu; }

        List<HomeMenuItem> menuItems;

        public MasterPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem{Id = MenuItemType.TicketListPage, Title="Tickets", Icon=IconFont.Home},
                new HomeMenuItem{Id = MenuItemType.BuyTicketPage, Title="Buy Ticket", Icon=IconFont.Ticket},
                new HomeMenuItem{Id = MenuItemType.AboutUsPage, Title="About Us", Icon=IconFont.InformationOutline},
                new HomeMenuItem{Id = MenuItemType.SettingPage, Title="Setting", Icon=IconFont.Cog},
                new HomeMenuItem{Id = MenuItemType.Logout, Title="Logout", Icon=IconFont.LocationExit}
            };

            MenuCollection.ItemsSource = menuItems;

            MenuCollection.ItemTapped += async (sender, e) =>
            {

                if (MenuCollection.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)MenuCollection.SelectedItem).Id;
                await RootPage.NavigatePage(id);

            };
        }
    }
}
