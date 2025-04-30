using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinWeterynarz
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int wartosc = Convert.ToInt32(slider.Value);
            
            labelek.Text = Convert.ToString(wartosc);
            
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(Convert.ToString(e.SelectedItem) == "Pies")
            {
                slider.Maximum = 18;

            }

            else if (Convert.ToString(e.SelectedItem) == "Kot")
            {
                slider.Maximum = 20;

            }

            else if (Convert.ToString(e.SelectedItem) == "Świnka Morska")
            {
                slider.Maximum = 9;

            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string ImieNazwisko = ImieorazNazwisko.Text;
            string Gatunek = Lista.SelectedItem.ToString();
            string Ilelat = labelek.Text;
            string CelWizyty = cel.Text;
            string godzina = Czas.Time.ToString();
            wypis.Text = $"Imie i nazwisko:{ImieNazwisko}, Gatunek:{Gatunek}, Wiek:{Ilelat}, Cel wizyty:{CelWizyty}, Godzina {godzina}";

        }
    }
}
