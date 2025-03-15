namespace okul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //girdiðimiz sayý dizide kaçýncý elemana denk geliyosa sonuca onu yazdýrýr
        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayi = { 11, 22, 33, 44, 55 };
            int a = Convert.ToInt16(textBox1.Text);      
            label1.Text = sayi[a - 1].ToString();
            listBox1.Items.Add(sayi[a - 1].ToString());

        }

        //listenin hepsini gösterir
        private void button2_Click(object sender, EventArgs e)
        {
            int[] sayi = { 11, 22, 33, 44, 55 };
            for (int i = 0; i < sayi.Length; i++)             
            {
                listBox1.Items.Add(sayi[i].ToString());
            }

        }

        //1-100 arasýnda 3 ve 11e tam bölünenleri yazdýr
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)                  
            {
                if (i % 3 == 0 || i % 11 == 0)
                {
                    listBox2.Items.Add(i.ToString());
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt16(textBox2.Text);
            int s2 = Convert.ToInt16(textBox3.Text);
            for (int i = 1; i < 100; i++)
            {
                if (i % s1 == 0 && i % s2 == 0)
                {
                    listBox2.Items.Add(i);
                }
            }
        }

        //arkadaþ sayý bulma 
        private void button5_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt16(textBox4.Text);            
            int sayi2 = Convert.ToInt16(textBox5.Text);
            int top1 = 0, top2 = 0;
            for (int i=1;i<sayi1;i++)
            {
                if(sayi1%i==0)
                {
                    top1 += i;
                }
            }
            for (int j = 1; j < sayi2; j++)
            {
                if (sayi2 % j == 0)
                {
                    top1 += j;
                }
            }
            if (top1==sayi2 && top2==sayi1)
            {
                label2.Text = "sayýlar arkadaþ";
            }
            else
            {
                label2.Text = "arkadaþ deðil";
            }
            
        }
    }
}
