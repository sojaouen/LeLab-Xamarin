using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace leLab.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        void CounterButtonClicked(System.Object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new CountPage());
        }

        void TabsPage_Clicked(System.Object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new TabsPage());
        }

        void ListPage_Clicked(System.Object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new ListPage());
        }
    }
}
