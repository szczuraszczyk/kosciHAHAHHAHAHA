using System;
using Microsoft.Maui.Controls;

namespace kosciHAHAHHAHAHA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int wynikGry = 0;
        Random generator = new Random();

        private void rzucamKoscmi(object sender, EventArgs e)
        {
            int ko1 = generator.Next(1, 7);
            int ko2 = generator.Next(1, 7);
            int ko3 = generator.Next(1, 7);
            int ko4 = generator.Next(1, 7);
            int ko5 = generator.Next(1, 7);

            kostkaJeden.Source = wezZdjecia(ko1);
            kostkaDwa.Source = wezZdjecia(ko2);
            kostkaTrzy.Source = wezZdjecia(ko3);
            kostkaCztery.Source = wezZdjecia(ko4);
            kostkaPiec.Source = wezZdjecia(ko5);

            int suma = ko1 + ko2 + ko3 + ko4 + ko5;
            wynikGry += suma;

            wynikLosTekst.Text = $"Wynik tego losowania: {suma}";
            wynikGryTekst.Text = $"Wynik gry: {wynikGry}";
        }

        private void resetujWynik(object sender, EventArgs e)
        {
            kostkaJeden.Source = "question.jpg";
            kostkaDwa.Source = "question.jpg";
            kostkaTrzy.Source = "question.jpg";
            kostkaCztery.Source = "question.jpg";
            kostkaPiec.Source = "question.jpg";

            wynikGry = 0;
            wynikLosTekst.Text = "Wynik tego losowania: 0";
            wynikGryTekst.Text = "Wynik gry: 0";
        }

        private string wezZdjecia(int value)
        {
            return value switch
            {
                1 => "k1.jpg",
                2 => "k2.jpg",
                3 => "k3.jpg",
                4 => "k4.jpg",
                5 => "k5.jpg",
                6 => "k6.jpg",
                _ => "question.jpg",
            };
        }
    }
}