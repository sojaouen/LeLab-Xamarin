using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace leLab.Views
{
    public partial class CountPage : ContentPage
    {
        private int valeur = 0;

        public CountPage()
        {

            InitializeComponent();
        }

        private void AjouterCompteur(object sender, EventArgs e)
        {
            Console.WriteLine("Bouton cliqué");
            valeur++;
            this.countLabel.Text = valeur.ToString();
        }
    }
}
