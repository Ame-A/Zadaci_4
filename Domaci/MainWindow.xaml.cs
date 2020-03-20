using System;
using System.Collections.ObjectModel;
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

namespace Domaci
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Imenik> Lista = new ObservableCollection<Imenik>();
        public MainWindow()
        {
            InitializeComponent();
            Datagrd1.ItemsSource = Lista;
            Datagrd2.ItemsSource = Lista;
            Datagrd3.ItemsSource = Lista;
        }

        private void Izbrisi(object sender, RoutedEventArgs e)
        {
            Lista.Remove(Datagrd1.SelectedItem as Imenik);
            Lista.Remove(Datagrd2.SelectedItem as Imenik);
        }

        public void Dup(object sender, RoutedEventArgs e)
        {
            Imenik SelecItem = (Imenik)Datagrd2.SelectedItem;
            if (SelecItem == null)
            {
                MessageBox.Show("Prvo morate da odaberete kontakt da bi ste ga izmenili!");
            }
            else
            {
                ImeII.Text = SelecItem.Ime;
                BrojII.Text = SelecItem.Broj;
            }
        }

        private void Dodaj(object sender, RoutedEventArgs e)
        {
            string tmpIme = ImeI.Text;
            string tmpBroj = BrojI.Text;
            if (Metode.Provera(Lista, tmpBroj, out Imenik I))
            {
                MessageBox.Show($"Vec postojeci kontakt sa istim brojem !  > {I.Ime} < ");
            }
            else if (tmpIme.Length == 0 || tmpBroj.Length == 0)
            {
                MessageBox.Show("Polja ne smeju biti prazna!");
            }
            else if (Metode.ProveraBroja(tmpBroj) == false)
            {
                MessageBox.Show("U polju za broj mozete da unesete samo numericke vrednosti!");
            }
            else
            {
                Lista.Add(new Imenik(tmpIme, tmpBroj));
                ImeI.Text = null;
                BrojI.Text = null;
                MessageBox.Show("Uspesno dodat novi kontakt!");

            }
        }

        private void Izmeni(object sender, RoutedEventArgs e)
        {
            string tmpIme = ImeII.Text;
            string tmpBroj = BrojII.Text;
            if (Metode.Provera(Lista, tmpBroj, out Imenik I))
            {
                MessageBox.Show($"Vec postojeci kontakt sa istim brojem !  > {I.Ime} < ");
            }
            else if (tmpIme.Length == 0 || tmpBroj.Length == 0)
            {
                MessageBox.Show("Polja ne smeju biti prazna!");
            }
            else if (Metode.ProveraBroja(tmpBroj) == false)
            {
                MessageBox.Show("U polju za broj mozete da unesete samo numericke vrednosti!");
            }
            else
            {
                Imenik SelectItem = (Imenik)Datagrd2.SelectedItem;
                SelectItem.Ime = tmpIme;
                SelectItem.Broj = tmpBroj;
                ImeII.Text = null;
                BrojII.Text = null;
                SelectItem = null;
            }
        }
    }
}

