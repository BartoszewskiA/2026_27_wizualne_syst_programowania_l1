namespace lab01p01
{
    public partial class Form1 : Form
    {
        private int licznik = 0;

        public Form1()
        {
            InitializeComponent();
            label1.Text = licznik.ToString();
            label1.ForeColor = Color.Blue;
        }


        private void akcja()
        {
            label1.Text = licznik.ToString();
            if (licznik > 0)
            {
                label1.ForeColor = Color.Green;
            }
            else if (licznik < 0)
            {
                label1.ForeColor = Color.Red;
            }
            else
            {
                label1.ForeColor = Color.Blue;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            licznik++;
            akcja();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            licznik--;
            akcja();
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            licznik = 0;
            akcja();

        }
    }
}
