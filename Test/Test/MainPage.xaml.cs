using System;
using Xamarin.Forms;

namespace Test
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            Rg.Plugins.Popup.Services.PopupNavigation.Instance.PushAsync(new MyPopup());

        }
    }
}
