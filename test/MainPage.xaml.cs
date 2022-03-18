using System;
using Xamarin.Forms;

namespace test
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ClickedCleanSignPlus(object sender, EventArgs args)
        {
            SignPlusView view = this.FindByName<SignPlusView>("SignPlusView");
            view.clearSignature();
        }

        private async void ClickedGetSignSignPlus(object sender, EventArgs args)
        {
            SignPlusView view = this.FindByName<SignPlusView>("SignPlusView");
            String result = await view.getSignature();
            Console.WriteLine(result);
        }
    }
}
