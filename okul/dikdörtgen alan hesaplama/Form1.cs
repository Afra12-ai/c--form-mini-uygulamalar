namespace dikdörtgen_alan_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisa = Convert.ToInt16(textBox1.Text);
            int uzun=Convert.ToInt16(textBox2.Text);
            int alan = kisa * uzun;
            int cevre = (kisa * uzun) * 2;
            label4.Text = "alan:" + alan;
            label3.Text = "çevre:" + cevre;
        }
    }
}
