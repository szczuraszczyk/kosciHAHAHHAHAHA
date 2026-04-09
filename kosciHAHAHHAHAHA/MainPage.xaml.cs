using System.Reflection.Emit;

namespace kosciHAHAHHAHAHA
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }


            int wynikGry = 0;
            Random generator = new Random();


            private void rzucamKoscmi(object? sender, EventArgs e)
            {
                int ko1 = generator.Next(1, 7);
                int ko2 = generator.Next(1, 7);
                int ko3 = generator.Next(1, 7);
                int ko4 = generator.Next(1, 7);
                int ko5 = generator.Next(1, 7);

                //kostkaJeden.Source = ImageSource.FromFile(wezZdjecia(ko1));
                //kostkaDwa.Source = ImageSource.FromFile(wezZdjecia(ko2));
                //kostkaTrzy.Source = ImageSource.FromFile(wezZdjecia(ko3));
                //kostkaCztery.Source = ImageSource.FromFile(wezZdjecia(ko4));
                //kostkaPiec.Source = ImageSource.FromFile(wezZdjecia(ko5));

                //int suma = ko1 + ko2 + ko3 + ko4 + ko5;
                //wynikGry += suma;

                //wynikLosTekst.Text = $"Wynik tego losowania: {suma}";
                //wynikGryTekst.Text = $"Wynik gry: {wynikGry}";
            }

            private void resetujWynik(object? sender, EventArgs e)
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

            //private string wezZdjecia(int value)
            //{
            //    return value switch
            //    {
            //        1 => "dice1.jpg",
            //        2 => "dice2.jpg",
            //        3 => "dice3.jpg",
            //        4 => "dice4.jpg",
            //        5 => "dice5.jpg",
            //        6 => "dice6.jpg",
            //        _ => "question.jpg",
            //    };
            //}
        }
    }