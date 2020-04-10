using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xam_onlineticket.Views
{
    public partial class BuyTicketPage : ContentPage
    {
        public BuyTicketPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SettingPage());
        }
    }
}
