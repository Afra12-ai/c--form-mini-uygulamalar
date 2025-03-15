namespace faktoriyel_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi,sonuc= 1;
            sayi = Convert.ToInt32(textBox1.Text);
            for (int fac = 1; fac <= sayi; fac++)
            {
                sonuc *= fac;
            }
            label1.Text = sonuc.ToString();
        }
    }
}
