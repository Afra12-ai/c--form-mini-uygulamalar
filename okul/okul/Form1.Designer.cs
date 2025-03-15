namespace okul
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            listBox2 = new ListBox();
            button4 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button5 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(39, 26);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "göster";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(139, 61);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(39, 61);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "listeye ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 31);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 4;
            label1.Text = "sonuç";
            // 
            // button3
            // 
            button3.BackColor = Color.DarkKhaki;
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(359, 31);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.DarkKhaki;
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(359, 66);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 104);
            listBox2.TabIndex = 6;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkKhaki;
            button4.Location = new Point(533, 31);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 7;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DarkKhaki;
            textBox2.Location = new Point(515, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DarkKhaki;
            textBox3.Location = new Point(515, 99);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 9;
            // 
            // button5
            // 
            button5.Location = new Point(137, 42);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 10;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 26);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(6, 59);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(button5);
            groupBox1.Location = new Point(438, 235);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 203);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "arkadaş sayı bulma";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 99);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 14;
            label2.Text = "arkadaş mı";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button4);
            Controls.Add(listBox2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button button2;
        private Label label1;
        private Button button3;
        private ListBox listBox2;
        private Button button4;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button5;
        private TextBox textBox4;
        private TextBox textBox5;
        private GroupBox groupBox1;
        private Label label2;
    }
}
