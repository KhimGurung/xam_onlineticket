using System;
using System.Collections.Generic;
using System.Text;
using xam_onlineticket.Helpers;

namespace xam_onlineticket.Models
{
    public enum MenuItemType
    {
        TicketListPage,
        BuyTicketPage,
        AboutUsPage,
        SettingPage,
        Logout
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }

        public string Icon { get; set; }
    }
}
