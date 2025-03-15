using System.Windows.Forms;

namespace buton_ile_form_açma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region buttona basıp message box açma 
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba dünya ben geldim.", "Hoş Geldiniz.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        }
        #endregion
        #region labela bi şey yazdır 
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "hello world";
        }
        #endregion
        #region combobox item ekle
        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }
        #endregion
        #region texboxta yazanı comboboxtan çıkar
        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(textBox1.Text);
        }
        #endregion
        #region listboxa item ekle
        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
        }
        #endregion
        #region listboxa seçileni ekleme ve çıkarma
        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox1.SelectedItem);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
        #endregion

        
    }
}
