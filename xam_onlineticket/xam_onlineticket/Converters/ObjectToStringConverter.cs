using System;
using System.Globalization;
using Newtonsoft.Json;
using xam_onlineticket.Controls;
using xam_onlineticket.Models;
using Xamarin.Forms;

namespace xam_onlineticket.Converters
{
    public class ObjectToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return JsonConvert.SerializeObject(value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

