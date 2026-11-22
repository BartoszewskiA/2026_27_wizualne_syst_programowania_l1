namespace lab05_kasyno
{
    public partial class Form1 : Form
    {

        const int TIMER_1 = 300;
        const int STAN_POPCZATKOWY = 100;
        const int STAWKA = 10;
        const int WYGRANA_1 = 100;
        const int WYGRANA_2 = 50;
        Random random = new Random();
        Color[] kolory = { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Orange, Color.Purple, Color.Pink };
        int los_1 = 0, los_2 = 1, los_3 = 3;
        int stan_konta;
        public Form1()
        {
            InitializeComponent();
            ustawienia_poczatkowe();
        }

        private void ustawienia_poczatkowe()
        {
            timer1.Interval = TIMER_1;
            stan_konta = STAN_POPCZATKOWY;
            label1.Text = "$ " + stan_konta.ToString() + " $";
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            los_1 = random.Next(0, kolory.Length);
            los_2 = random.Next(0, kolory.Length);
            los_3 = random.Next(0, kolory.Length);
            panel1.BackColor = kolory[los_1];
            panel2.BackColor = kolory[los_2];
            panel3.BackColor = kolory[los_3];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ustawienia_poczatkowe();
            timer1.Start();
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (los_1 == los_2 && los_2 == los_3)
                stan_konta += WYGRANA_1;
            else if (los_1 == los_2 || los_2 == los_3 || los_1 == los_3)
                stan_konta += WYGRANA_2;
            else
                stan_konta -= STAWKA;
            label1.Text = "$ " + stan_konta.ToString() + " $";
            timer1.Stop();
            button1.Enabled = false;
            timer2.Start();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = true;
            timer2.Stop();
        }
    }
}
