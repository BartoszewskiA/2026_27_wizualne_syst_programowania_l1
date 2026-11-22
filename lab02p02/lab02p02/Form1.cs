namespace lab02p02
{
    public partial class Form1 : Form
    {
        Random random;
        private int liczba_scian = 6;
        private int tymczasowa_liczba_scian = 0;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            label3.Text = liczba_scian.ToString();
            hScrollBar1.Minimum = 2;
            hScrollBar1.Maximum = 16;
            hScrollBar1.Value = liczba_scian / 2;
            label4.Text = (hScrollBar1.Value * 2).ToString();
            tymczasowa_liczba_scian = hScrollBar1.Value * 2;
            label1.Text = losuj(liczba_scian).ToString();
        }
        private int losuj(int zakres)
        {
            return random.Next(zakres) + 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = losuj(liczba_scian).ToString();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label4.Text = (hScrollBar1.Value * 2).ToString();
            tymczasowa_liczba_scian = hScrollBar1.Value * 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            liczba_scian = tymczasowa_liczba_scian;
            label3.Text = liczba_scian.ToString();
            label4.Visible = false;
            hScrollBar1.Visible = false;
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            hScrollBar1.Visible = true;
            button2.Visible = true;
        }
    }

}
