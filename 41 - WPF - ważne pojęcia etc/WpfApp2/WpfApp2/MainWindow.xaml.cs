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

namespace WpfApp2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>

    /*  Podstawowe kolejności Dziedziczenia z dołu do góry i na odwrót
     *  tu jest poazane jak kombinowac z butonem w butonie
     *  łączanie wyłaćzanie buttona IsEnabled="False" or True
     *  FontFamily dziedziczenie czcionek itp fakt że nie wszystko ma tę funkcję
     *  Umieszczanie obrazów
     *  Umiejscawianie siatki w siatce
     *  ustawianie marginesów
     *  dodatkowe mesage boxy
     *  */


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Test");
            test.Text = "zstało kliknięte";
        }
    }
}
