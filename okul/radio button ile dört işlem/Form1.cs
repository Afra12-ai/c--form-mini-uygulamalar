namespace radio_button_ile_dört_işlem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sonuc;
            double sayi1= Double.Parse(textBox1.Text);
            double sayi2= Double.Parse(textBox2.Text);
            if(radioButton1.Checked)
            {
                sonuc = sayi1 + sayi2;
            }
            else if(radioButton2.Checked)
            {
                sonuc= sayi1 - sayi2;
            }
            else if(radioButton3.Checked)
            {
                sonuc = sayi1 * sayi2;
            }
            else
            {
                sonuc = sayi1 / sayi2;
            }
            label3.Text = sonuc.ToString();
        }
    }
}
