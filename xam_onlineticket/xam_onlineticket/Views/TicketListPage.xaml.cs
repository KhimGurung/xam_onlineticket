using System;
using System.Collections.Generic;
using xam_onlineticket.Models;
using xam_onlineticket.ViewModels;
using Xamarin.Forms;

namespace xam_onlineticket.Views
{
    public partial class TicketListPage : ContentPage
    {
        TicketListViewModel ticketListViewModel;
        public TicketListPage()
        {
            InitializeComponent();

            NavigationPage.SetBackButtonTitle(this, "");

            ticketListViewModel = new TicketListViewModel();

            this.BindingContext = ticketListViewModel;

        }


        void SelectValid(Object sender, EventArgs e)
        {
            Indicator.LayoutTo(new Rectangle(16, 0, 70, Indicator.Height), 200);
            ticketListViewModel.FilterTicket(Tickets.TicketValidity.Valid);
        }

        void SelectExpired(Object sender, EventArgs e)
        {
            Indicator.LayoutTo(new Rectangle(106, 0, 90, Indicator.Height), 200);
            ticketListViewModel.FilterTicket(Tickets.TicketValidity.Expired);
        }

        void SelectAll(Object sender, EventArgs e)
        {
            Indicator.LayoutTo(new Rectangle(216, 0, 50, Indicator.Height), 200);
            ticketListViewModel.FilterTicket(Tickets.TicketValidity.All);
        }

        void ticketList_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            Tickets ticket = (Tickets)((ListView)sender).SelectedItem;
            Navigation.PushAsync(new TicketDetailPage(ticket));
        }
    }
}
