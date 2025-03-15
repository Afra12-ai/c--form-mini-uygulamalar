using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace listboxtak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(label1.Text);
            listBox1.Items.Add(sayi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                toplam+=Convert.ToInt32(listBox1.Items[i]);
            }   
            label2.Text="toplam:" + toplam.ToString();

        }
    }
}
