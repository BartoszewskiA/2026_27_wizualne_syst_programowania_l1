namespace lab01p02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int x = int.Parse(textBox1.Text);
            //int y = int.Parse(textBox2.Text);
            int x = 0, y = 0;
            if(!int.TryParse(textBox1.Text, out x))
            {
                MessageBox.Show("Niepoprawna wartość w polu 1");
                return;
            }
            if(!int.TryParse(textBox2.Text, out y))
            {
                MessageBox.Show("Niepoprawna wartość w polu 2");
                return;
            }
            int wynik = x + y;
            label3.Text = wynik.ToString();
        }
    }
}
