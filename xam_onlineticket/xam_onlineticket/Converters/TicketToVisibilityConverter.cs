using System;
using System.Globalization;
using xam_onlineticket.Models;
using Xamarin.Forms;

namespace xam_onlineticket.Converters
{
    public class TicketToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is Tickets)
            {
                if (value is PartyTicket && string.Equals(parameter.ToString(), "PartyTicket"))
                    return true;

                if (value is VisitTicket && string.Equals(parameter.ToString(), "VisitTicket"))
                    return true;

                if (value is TravelTicket && string.Equals(parameter.ToString(), "TravelTicket"))
                    return true;

                if (value is ShowTicket && string.Equals(parameter.ToString(), "ShowTicket"))
                    return true;

                return false;
            }

            if (string.Equals(parameter.ToString(), "ticketStatus") || string.Equals(parameter.ToString(), "expired"))
            {
                return (bool)value == false ? true : false;
            }

            return (bool)value == false ? false : true;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

