using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Rg.Plugins.Popup.Services;
using xam_onlineticket.Converters;
using xam_onlineticket.Models;
using xam_onlineticket.Views;
using Xamarin.Forms;

namespace xam_onlineticket.Controls
{
    public partial class QRCode : ContentView
    {
        public static readonly BindableProperty TicketDetailProperty =
            BindableProperty.Create("TicketDetail",
                typeof(string),
                typeof(QRCode));

        public string TicketDetail
        {
            get { return (string)GetValue(TicketDetailProperty); }
            set { SetValue(TicketDetailProperty, value); }
        }

        public static readonly BindableProperty TicketNoProperty =
            BindableProperty.Create("TicketNo",
                typeof(string),
                typeof(QRCode));

        public string TicketNo
        {
            get { return (string)GetValue(TicketNoProperty); }
            set { SetValue(TicketNoProperty, value); }
        }

        public static readonly BindableProperty ValidProperty =
            BindableProperty.Create("Valid",
                typeof(bool),
                typeof(QRCode));

        public bool Valid
        {
            get { return (bool)GetValue(ValidProperty); }
            set { SetValue(ValidProperty, value); }
        }

        public static readonly BindableProperty UsedProperty =
            BindableProperty.Create("Used",
                typeof(bool),
                typeof(QRCode));

        public bool Used
        {
            get { return (bool)GetValue(UsedProperty); }
            set { SetValue(UsedProperty, value); }
        }

        public static readonly BindableProperty ExpiredProperty =
            BindableProperty.Create("Expired",
                typeof(bool),
                typeof(QRCode));

        public bool Expired
        {
            get { return (bool)GetValue(ExpiredProperty); }
            set { SetValue(ExpiredProperty, value); }
        }

        public QRCode()
        {
            InitializeComponent();
        }

        async void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Image image = (Image)sender;
            await PopupNavigation.Instance.PushAsync(new QRCodePage(image.ClassId));
        }
    }
}
