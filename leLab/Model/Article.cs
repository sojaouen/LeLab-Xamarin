using System;
namespace leLab.Model
{
    public class Article
    {
        private float prix;

        public String Nom { get; set; }

        public float Prix {get => prix;
            set
            {
                if (value > 0)
                    prix = value;
            }
        }

        public String PrixEuro {
            get
            {
                return String.Format("{0:0.00} €", prix);
            }

        }
    }
}