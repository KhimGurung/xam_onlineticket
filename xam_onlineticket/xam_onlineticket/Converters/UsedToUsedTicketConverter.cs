using System;
using System.Globalization;
using Xamarin.Forms;

namespace xam_onlineticket.Converters
{
    public class UsedToUsedTicketConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
