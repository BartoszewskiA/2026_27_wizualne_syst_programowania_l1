using System.Windows.Forms.VisualStyles;

namespace lab03p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";
            radioButton1.Checked = true;
            radioButton5.Checked = true;
        }

        double przelicz(double x, int w1, int w2)
        // w1 - waluta wejściowa, w2 - waluta wyjściowa
        // 1- PLN, 2 -EURO, 3 -USD
        {
            double kurs_EURO = 4.37;
            double kurs_USD = 3.9;
            double waluta_przeliczeniowa = 0;
            double wynik = 0;
            switch(w1)
            {
                case 1:
                    waluta_przeliczeniowa = x;
                    break;
                case 2:
                    waluta_przeliczeniowa = x * kurs_EURO;
                    break;
                case 3:
                    waluta_przeliczeniowa = x * kurs_USD;
                    break;
            }
            switch(w2)
            {
                case 1:
                    wynik = waluta_przeliczeniowa;
                    break;
                case 2:
                    wynik = waluta_przeliczeniowa / kurs_EURO;
                    break;
                case 3:
                    wynik = waluta_przeliczeniowa / kurs_USD;
                    break;
            }
            wynik = Math.Round(wynik, 2);
            return wynik;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dana = 0;
            if(!int.TryParse(textBox1.Text, out dana))
            {
                MessageBox.Show("Niepoprawna dana wejściowa");
                textBox1.Text = "0";
                return;
            }
            int w1=0, w2=0;
            if (radioButton1.Checked)
                w1 = 1;
            else if (radioButton2.Checked)
                w1 = 2;
            else
                w1 = 3;

            if (radioButton4.Checked)
                w2 = 1;
            else if (radioButton5.Checked)
                w2 = 2;
            else
                w2 = 3;

            textBox2.Text = przelicz(dana, w1, w2).ToString();
        }
    }
}
