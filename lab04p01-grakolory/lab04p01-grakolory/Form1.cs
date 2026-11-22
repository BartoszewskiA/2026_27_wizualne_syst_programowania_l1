namespace lab04p01_grakolory
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        String[] nazwy = { "Czerwony", "Zielony", "Niebieski", "Żółty" };
        Color[] kolory = { Color.Red, Color.Green, Color.Blue, Color.Yellow };
        int numerKoloru = 0;
        int numerNazwy = 0;
        int licznikTrafien = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            numerKoloru = random.Next(0, kolory.Length);
            numerNazwy = random.Next(0, nazwy.Length);
            label1.Text = nazwy[numerNazwy];
            label1.ForeColor = kolory[numerKoloru];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false) timer1.Start();
            if (!timer2.Enabled) timer2.Start();
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {

        }

        private void zaliczTrafienie(int v)
        {
            if (v == numerKoloru)
            {
                licznikTrafien++;
                label2.Text = "Licznik trafień: " + licznikTrafien.ToString();
                if (timer1.Interval > 100) timer1.Interval -= 10;
            }
            else
            {

            }
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            zaliczTrafienie(0);
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            zaliczTrafienie(1);
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            zaliczTrafienie(2);
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            zaliczTrafienie(3);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Koniec gry! Liczba trafień: " + licznikTrafien.ToString());
            label2.Text = "Licznik trafień: 0";
            timer2.Stop();
        }
    }
}
