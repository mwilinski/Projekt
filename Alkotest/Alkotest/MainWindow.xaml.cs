using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Alkotest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Person> wyniki;
        Person osoba;
        Alkohole alko;
        Alkohole.Rodzaje alkohol;
        public MainWindow()
        {
            wyniki = new List<Person>();
            InitializeComponent();

        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            alko = new Alkohole();
            if (System.Convert.ToBoolean(kobieta.IsChecked))
                osoba = new Women();
            if (System.Convert.ToBoolean(mezczyzna.IsChecked))
                osoba = new Man();
            try
            {
                osoba.waga = int.Parse(wagabox.Text);
            }
            catch
            {
                wagabox.Text = "Zły format";
            }
            osoba.imie = imie.Text;
            alko.ilosc = double.Parse(ilebox.Text);
            
            if (System.Convert.ToBoolean(piwo.IsChecked))
                alkohol=alko.zwrocRodzaj("piwo");
            else if (System.Convert.ToBoolean(wodka.IsChecked))
                alkohol=alko.zwrocRodzaj("wodka");
            else if (System.Convert.ToBoolean(wino.IsChecked))
                alkohol = alko.zwrocRodzaj("wino");
            osoba.wynik = osoba.policz(alko.zwrocCzystyAlko(alkohol));
            wynik.Text =System.Convert.ToString(osoba.wynik);
            imiemtwoje.Text = osoba.imie;
            wyniki.Add(osoba);
        }

        private void minbut_Click(object sender, RoutedEventArgs e)
        {
            try {
                minmax.Text = System.Convert.ToString(wyniki[0].wynik);
                imieminmax.Text = wyniki[0].imie;
            } 
            catch
            {
                minmax.Text = "brak";
                imieminmax.Text = "";
             }
            }

        private void maxbut_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                minmax.Text = System.Convert.ToString(wyniki[wyniki.Count - 1].wynik);
                imieminmax.Text = wyniki[wyniki.Count - 1].imie;
            }
            catch
            {
                minmax.Text = "brak";
                imieminmax.Text = "";
            }
        }
    }
}
