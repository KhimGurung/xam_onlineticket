using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xam_onlineticket.Views
{
    public partial class AboutUsPage : ContentPage
    {
        public AboutUsPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BuyTicketPage());
        }
    }
}
