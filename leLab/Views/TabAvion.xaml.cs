using System;
using System.Collections.Generic;

using Xamarin.Forms;


namespace leLab.Views
{
    public partial class TabAvion : ContentPage
    {
        public TabAvion()
        {
            InitializeComponent();
            this.avionImage.TranslationX = -300;
            this.avionImage.TranslationY = -200;
            this.avionImage.Rotation = 45;
            this.avionImage.Opacity = 0;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.avionImage.TranslateTo(0, 0, 3000, Easing.CubicInOut);
            this.avionImage.RotateTo(0, 3000, Easing.CubicInOut);
            this.avionImage.FadeTo(1, 1500, Easing.CubicInOut);
            this.avionImage.ScaleTo(1, 3000, Easing.CubicInOut);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            this.avionImage.TranslationX = -300;
            this.avionImage.Opacity = 0;
            this.avionImage.TranslationY = -200;
            this.avionImage.Rotation = 45;
            this.avionImage.Scale = 0.5;
        }
    }
}