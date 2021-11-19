using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace leLab.Views
{
    public partial class TabVoiture : ContentPage
    {
        public TabVoiture()
        {
            InitializeComponent();
            this.voitureImage.TranslationX = -300;
            this.voitureImage.Opacity = 0;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.voitureImage.TranslateTo(0, 0, 2000, Easing.CubicInOut);
            this.voitureImage.FadeTo(1, 1500, Easing.CubicInOut);
            Console.WriteLine("OnAppearing");
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            this.voitureImage.TranslationX = -300;
            this.voitureImage.Opacity = 0;
            Console.WriteLine("OnDisappearing");
        }
    }
}
