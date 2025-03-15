namespace iki_sayı_arası_sayıların_toplamı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region iki sayı arasındaki sayıları topla
        private void button1_Click(object sender, EventArgs e)
        {
            
            int sayi1, sayi2;
            int sonuc = 0;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            for (int i = sayi1 + 1; i < sayi2; i++)
            {
                sonuc = sonuc + i;
            }

            label3.Text = sonuc.ToString();
            
        }
        #endregion
        #region iki sayı arasındaki asal sayıları yazdır
        private void button2_Click(object sender, EventArgs e)
        {
            int s1, s2;
            s1 = Convert.ToInt16(textBox3.Text);
            s2 = Convert.ToInt16(textBox4.Text);
            for(int i=s1;i<=s2;i++)
            {
                int kontrol = 0; //asal olup olmadığını kontrol ederiz
                for(int j=2;j<i;j++) //i sayısını 2den başlayarak kendisinden 1 eksik olana kadar dolaşacağız.1 ve kendisi hariç sayılara bölünüp bölünmediğine bakacağız
                {
                    if(i%j==0)
                    {
                        //eğer tam bölündüyse asal sayı değildir
                        kontrol++;
                        break;
                    }
                }
                if(kontrol==0)
                {
                    listBox1.Items.Add(i);
                }
            }

        }
        #endregion
    }
}
