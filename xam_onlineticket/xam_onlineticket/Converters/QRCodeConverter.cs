using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using Newtonsoft.Json;
using QRCoder;
using xam_onlineticket.Models;
using Xamarin.Forms;

namespace xam_onlineticket.Converters
{
    public class QRCodeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("Click on QR Code to scan", QRCodeGenerator.ECCLevel.Q);
            PngByteQRCode qRCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeBytes = qRCode.GetGraphic(20);

            return ImageSource.FromStream(() => new MemoryStream(qrCodeBytes));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
