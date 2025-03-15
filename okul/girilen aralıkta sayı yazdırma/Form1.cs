namespace girilen_aralıkta_sayı_yazdırma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt16(textBox1.Text);
            int sayi2 = Convert.ToInt16(textBox2.Text);
            for (int i=sayi1; i<=sayi2; i++)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
