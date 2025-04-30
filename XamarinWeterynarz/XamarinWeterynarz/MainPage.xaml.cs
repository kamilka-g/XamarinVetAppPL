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
        private readonly AnimalService animalService;
        private readonly VisitFormatter visitFormatter;

        public MainPage()
        {
            InitializeComponent();
            animalService = new AnimalService();
            visitFormatter = new VisitFormatter();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int wartosc = Convert.ToInt32(slider.Value);
            labelek.Text = wartosc.ToString();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is string selectedSpecies)
            {
                slider.Maximum = animalService.GetMaxAge(selectedSpecies);
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string imieNazwisko = ImieorazNazwisko.Text;
            string gatunek = Lista.SelectedItem?.ToString() ?? "Nieznany";
            string ileLat = labelek.Text;
            string celWizyty = cel.Text;
            string godzina = Czas.Time.ToString();

            wypis.Text = visitFormatter.FormatVisit(imieNazwisko, gatunek, ileLat, celWizyty, godzina);
        }
    }
}
