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

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

