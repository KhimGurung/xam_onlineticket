using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using PropertyChanged;
using xam_onlineticket.Models;

namespace xam_onlineticket.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class TicketListViewModel
    {
        public List<Tickets> TicketList { get; set; }
        public Tickets Tickets { get; set; }

        public TicketListViewModel()
        {
            TicketList = new List<Tickets>();

            Tickets = new Tickets();

            TicketList = Tickets.GetTickets().FindAll(ticket => ticket.Valid == true);

        }

        public void FilterTicket(Tickets.TicketValidity validity)
        {
            if(validity == Tickets.TicketValidity.All)
                TicketList = Tickets.GetTickets();
            else if (validity == Tickets.TicketValidity.Expired)
                TicketList = Tickets.GetTickets().FindAll(ticket => ticket.Valid == false);
            else if (validity == Tickets.TicketValidity.Valid)
                TicketList = Tickets.GetTickets().FindAll(ticket => ticket.Valid == true);
        }
    }
}
