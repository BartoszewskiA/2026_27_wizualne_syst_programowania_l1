using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab06p01_kolory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void suwakR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Color k1 = Color.FromRgb((Byte)e.NewValue, 0, 0);
            p1.Fill = new SolidColorBrush(k1);
            labelR.Content = Math.Round(suwakR.Value).ToString();
            kolor_probnika();
        }

        private void suwakG_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            p2.Fill = new SolidColorBrush(Color.FromRgb(0,(Byte)e.NewValue,0));
            labelG.Content = Math.Round(suwakG.Value).ToString();
            kolor_probnika();
        }

        private void suwakB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            p3.Fill = new SolidColorBrush(Color.FromRgb(0, 0, (Byte)e.NewValue));
            labelB.Content = Math.Round(suwakB.Value).ToString();
            kolor_probnika();
        }

        private void kolor_probnika()
        {
            if(suwakR == null || suwakG == null || suwakB == null || probnik == null ||druk== null) return;
            Color k1;
            if (druk.IsChecked == false)
            {
                k1 = Color.FromRgb((Byte)suwakR.Value, (Byte)suwakG.Value, (Byte)suwakB.Value);
            }
            else
            {
                int szarosc = ((int)suwakR.Value + (int)suwakG.Value + (int)suwakB.Value) / 3;
                k1 = Color.FromRgb((Byte)szarosc, (Byte)szarosc, (Byte)szarosc);
            }
            
            
            probnik.Fill = new SolidColorBrush(k1);
        }

        private void druk_Click(object sender, RoutedEventArgs e)
        {
            kolor_probnika();
        }
    }
}