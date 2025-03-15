namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);
            label1.Text = (Convert.ToInt16(textBox1.Text) + Convert.ToInt16(textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = (Convert.ToInt16(textBox1.Text) - Convert.ToInt16(textBox2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = (Convert.ToInt16(textBox1.Text) * Convert.ToInt16(textBox2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = (Convert.ToInt16(textBox1.Text) / Convert.ToInt16(textBox2.Text)).ToString();
        }
    }

}
