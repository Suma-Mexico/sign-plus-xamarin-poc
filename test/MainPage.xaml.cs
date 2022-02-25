using System;
using Xamarin.Forms;
using sign_plus_sdk;

namespace test
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ClickedShowSignPlus(object sender, EventArgs args)
        {
            var signPlusPage = new SignPlusPage("JoseLuisAcosta_Others", "Ej4QpQ33HYwZ2JXYTLCf6c1li3vTLhjm", "14f8fc7c-8f04-451e-ad57-a0bb1d8c11e1", "7f14c9e4-ed85-41c7-a6ef-ef75ee35e435");
            await Navigation.PushAsync(new NavigationPage(signPlusPage));
        }
    }
}
