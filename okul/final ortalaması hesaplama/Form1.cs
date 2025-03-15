namespace final_ortalaması_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            double vize, final, ortalama;
            vize = Convert.ToDouble(textBox1.Text);
            final = Convert.ToDouble(textBox2.Text);
            ortalama = vize * 0.4 + final * 0.6;
            label5.Text = ortalama.ToString();
            if(ortalama < 60)
            {
                label6.Text = "kaldınız";
                this.BackColor = Color.Red;
            }
            else 
            {
                label6.Text = "geçtiniz";
                this.BackColor = Color.Green;
            }
        }
    }
}
