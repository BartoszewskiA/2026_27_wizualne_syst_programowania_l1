namespace lab02p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = hScrollBar1.Value.ToString();
            label4.Text = hScrollBar2.Value.ToString();
            oblicz();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label2.Text = hScrollBar1.Value.ToString();
            oblicz();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label4.Text = hScrollBar2.Value.ToString();
            oblicz();
        }

        private void oblicz()
        {
            int a = hScrollBar1.Value;
            int b = hScrollBar2.Value;
            label6.Text = (2*(a + b)).ToString();
            label8.Text = (a * b).ToString();

        }
    }
}
