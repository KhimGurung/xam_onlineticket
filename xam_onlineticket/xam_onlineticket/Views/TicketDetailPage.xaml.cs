using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using QRCoder;
using xam_onlineticket.Models;
using xam_onlineticket.ViewModels;
using Xamarin.Forms;

namespace xam_onlineticket.Views
{
    public partial class TicketDetailPage : ContentPage
    {
        TicketDetailViewModel ticketDetailViewModel;
        public TicketDetailPage(Tickets ticket)
        {
            InitializeComponent();

            ticketDetailViewModel = new TicketDetailViewModel(ticket);

            BindingContext = ticketDetailViewModel;

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(JsonConvert.SerializeObject(ticket), QRCodeGenerator.ECCLevel.Q);
            PngByteQRCode qRCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeBytes = qRCode.GetGraphic(20);
            qrCode.Source = ImageSource.FromStream(() => new MemoryStream(qrCodeBytes));
        }
    }
}
