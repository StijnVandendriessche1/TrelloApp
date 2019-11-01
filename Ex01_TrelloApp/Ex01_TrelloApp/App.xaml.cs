using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Ex01_TrelloApp.Views;

namespace Ex01_TrelloApp
{
    public partial class App : Application
    {
        public TrelloNoConnectionPage TrelloNoConnectionPage { get; private set; }

        public App()
        {
            InitializeComponent();
            //MainPage = new MainPage();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
