using System;
using PropertyChanged;
using xam_onlineticket.Models;

namespace xam_onlineticket.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class TicketDetailViewModel
    {
        private Tickets selectedTicket;
        public TicketDetailViewModel(Tickets ticket)
        {
            SelectedTicket = new Tickets();

            SelectedTicket = ticket;
        }

        public Tickets SelectedTicket { get => selectedTicket; set => selectedTicket = value; }
    }
}
