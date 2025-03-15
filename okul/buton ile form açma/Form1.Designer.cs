namespace buton_ile_form_açma
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
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button4 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button6 = new Button();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            button7 = new Button();
            button5 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(3, 12);
            button1.Name = "button1";
            button1.Size = new Size(124, 40);
            button1.TabIndex = 0;
            button1.Text = "message box aç";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(3, 58);
            button2.Name = "button2";
            button2.Size = new Size(124, 38);
            button2.TabIndex = 1;
            button2.Text = "labela yazdır";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 99);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // button3
            // 
            button3.Location = new Point(9, 59);
            button3.Name = "button3";
            button3.Size = new Size(69, 29);
            button3.TabIndex = 3;
            button3.Text = "ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(84, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // button4
            // 
            button4.Location = new Point(241, 60);
            button4.Name = "button4";
            button4.Size = new Size(67, 29);
            button4.TabIndex = 6;
            button4.Text = "sil";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(133, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 125);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "combobox";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(listBox1);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button5);
            groupBox2.Location = new Point(469, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 194);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "listbox";
            // 
            // button6
            // 
            button6.Location = new Point(227, 125);
            button6.Name = "button6";
            button6.Size = new Size(44, 29);
            button6.TabIndex = 4;
            button6.Text = "+";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(82, 26);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(227, 15);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(99, 104);
            listBox1.TabIndex = 2;
            // 
            // button7
            // 
            button7.Location = new Point(285, 125);
            button7.Name = "button7";
            button7.Size = new Size(41, 29);
            button7.TabIndex = 1;
            button7.Text = "-";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button5
            // 
            button5.Location = new Point(6, 26);
            button5.Name = "button5";
            button5.Size = new Size(70, 29);
            button5.TabIndex = 0;
            button5.Text = "ekle";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(808, 491);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button5;
        private ListBox listBox1;
        private Button button7;
        private TextBox textBox2;
        private Button button6;
    }
}
