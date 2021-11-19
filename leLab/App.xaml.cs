using System;
using leLab.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace leLab
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new CountPage();
            //MainPage = new MenuPage();
            MainPage = new NavigationPage(new MenuPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
