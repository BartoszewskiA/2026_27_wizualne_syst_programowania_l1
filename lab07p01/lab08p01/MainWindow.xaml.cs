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
using System.Windows.Forms;

namespace lab08p01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        System.Windows.Forms.FontDialog fontDialog;
        System.Windows.Forms.ColorDialog colorDialog;
        System.Windows.Forms.ColorDialog colorDialog_2;

        public MainWindow()
        {
            InitializeComponent();
            textBlock1.Text = Tekst.lorem_ipsum;
            fontDialog = new System.Windows.Forms.FontDialog();
            colorDialog = new System.Windows.Forms.ColorDialog();
            colorDialog_2 = new System.Windows.Forms.ColorDialog();
        }

        private void btn_fonty_Click(object sender, RoutedEventArgs e)
        {
            
            fontDialog.ShowDialog();
            String fontFamily = fontDialog.Font.FontFamily.Name.ToString();
            float fontSize = fontDialog.Font.Size;
            String fontStyle = fontDialog.Font.Style.ToString();
      
            textBlock1.FontFamily = new System.Windows.Media.FontFamily(fontFamily);
            textBlock1.FontSize = fontSize;
            slider1.Value = fontSize;
            textBlock1.FontStyle = (fontStyle == "Italic") ? FontStyles.Italic : FontStyles.Normal;
        }

        private void btn_kol_fontow_Click(object sender, RoutedEventArgs e)
        {
            
            colorDialog.ShowDialog();
            byte r = colorDialog.Color.R;
            byte g = colorDialog.Color.G;
            byte b = colorDialog.Color.B;
            textBlock1.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(r, g, b));
        }

        private void btn_kol_tla_Click(object sender, RoutedEventArgs e)
        {
            
            colorDialog_2.ShowDialog();
            byte r = colorDialog_2.Color.R;
            byte g = colorDialog_2.Color.G;
            byte b = colorDialog_2.Color.B;
            textBlock1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(r, g, b));
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            textBlock1.FontSize = (float)e.NewValue;
        }
    }
}