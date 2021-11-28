using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Test
{
    public partial class MainPage : ContentPage
    {

        public ICommand PressedCommand => new Command(() => {
            Count++;
        });

        private int count = 10;
        public int Count {
            get => count;
            set { count = value; OnPropertyChanged(nameof(Count)); }
        }



        public MainPage()
        {
            BindingContext = this;
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e) => Rg.Plugins.Popup.Services.PopupNavigation.Instance.PushAsync(new MyPopup());

        private void MainWindowButton_Clicked(object sender, EventArgs e) => Count++;

    }
}
