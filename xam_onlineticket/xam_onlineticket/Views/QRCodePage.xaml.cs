using System;
using System.Collections.Generic;
using System.IO;
using QRCoder;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;

namespace xam_onlineticket.Views
{
    public partial class QRCodePage : PopupPage
    {
        public QRCodePage(string ticket)
        {
            InitializeComponent();

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(ticket, QRCodeGenerator.ECCLevel.Q);
            PngByteQRCode qRCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeBytes = qRCode.GetGraphic(20);
            qrCode.Source = ImageSource.FromStream(() => new MemoryStream(qrCodeBytes));

        }
    }
}
