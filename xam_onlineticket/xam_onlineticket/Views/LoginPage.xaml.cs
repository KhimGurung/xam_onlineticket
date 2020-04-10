using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xam_onlineticket.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage = new SideMenu();
        }
    }
}
