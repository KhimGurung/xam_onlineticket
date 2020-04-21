using System;
using xam_onlineticket.Models;
using Xamarin.Forms;

namespace xam_onlineticket.Controls
{
    public class TicketDataTemplateSelector : DataTemplateSelector
    {

        private DataTemplate ShowTicketTemplate = new DataTemplate(typeof(ShowTicketTemplate));
        private DataTemplate TravelTicketTemplate = new DataTemplate(typeof(TravelTicketTemplate));
        private DataTemplate PartyTicketTemplate = new DataTemplate(typeof(PartyTicketTemplate));
        private DataTemplate VisitTicketTemplate = new DataTemplate(typeof(VisitTicketTemplate));

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var ticket = item as Tickets;

            if (ticket is ShowTicket)
                return ShowTicketTemplate;
            else if (ticket is TravelTicket)
                return TravelTicketTemplate;
            else if (ticket is PartyTicket)
                return PartyTicketTemplate;
            else
                return VisitTicketTemplate;
        }
    }
}
