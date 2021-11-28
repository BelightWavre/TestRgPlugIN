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


        private void MainWindowButton_Clicked(object sender, EventArgs e) => Count++;


        #region Rg.Plugin.Popup Test With Callback
        
        MyPopup TestPopup;

        private void Button_Clicked(object sender, EventArgs e)
        {
            TestPopup = new MyPopup();
            TestPopup.Callback += TestPopup_Callback;
            TestPopup.OnDispose += TestPopup_OnDispose;
            Rg.Plugins.Popup.Services.PopupNavigation.Instance.PushAsync(TestPopup);
        }

        private void TestPopup_OnDispose()
        {
            TestPopup.Callback -= TestPopup_Callback;
            TestPopup.OnDispose -= TestPopup_OnDispose;
        }

        private void TestPopup_Callback() => Count = TestPopup.Count; 
        
        #endregion

    }
}
