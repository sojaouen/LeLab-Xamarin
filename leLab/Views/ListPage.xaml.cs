using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using leLab.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace leLab.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        private List<Article> articles = new List<Article>();

        public ListPage()
        {
            InitializeComponent();
            Article art1 = new Article { Nom = "Lait", Prix = 4.5f };
            articles.Add(art1);
            articles.Add(new Article { Nom = "Banane", Prix = 2.8f });
            articles.Add(new Article { Nom = "Oeufs", Prix = 3.50f });

            this.myListView.ItemsSource = articles;

            this.myListView.ItemSelected += MyListView_ItemSelected;

        }

        private void MyListView_ItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            Console.WriteLine("item liste selectionné");
            Article item = this.myListView.SelectedItem as Article;
            DisplayAlert("Detail", "Nom: " + item.Nom + "/" + "Prix: " + item.PrixEuro, "OK");
        }
    }
}
