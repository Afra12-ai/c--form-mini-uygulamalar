namespace final_ortalaması_hesaplama
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            vize = new Label();
            final = new Label();
            hesapla = new Button();
            ortalama = new Label();
            durum = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(201, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(201, 188);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // vize
            // 
            vize.AutoSize = true;
            vize.Location = new Point(160, 147);
            vize.Name = "vize";
            vize.Size = new Size(35, 20);
            vize.TabIndex = 2;
            vize.Text = "vize";
            // 
            // final
            // 
            final.AutoSize = true;
            final.Location = new Point(157, 188);
            final.Name = "final";
            final.Size = new Size(38, 20);
            final.TabIndex = 3;
            final.Text = "final";
            // 
            // hesapla
            // 
            hesapla.Location = new Point(217, 221);
            hesapla.Name = "hesapla";
            hesapla.Size = new Size(94, 29);
            hesapla.TabIndex = 4;
            hesapla.Text = "hesapla";
            hesapla.UseVisualStyleBackColor = true;
            hesapla.Click += hesapla_Click;
            // 
            // ortalama
            // 
            ortalama.AutoSize = true;
            ortalama.Location = new Point(385, 140);
            ortalama.Name = "ortalama";
            ortalama.Size = new Size(69, 20);
            ortalama.TabIndex = 5;
            ortalama.Text = "ortalama";
            // 
            // durum
            // 
            durum.AutoSize = true;
            durum.Location = new Point(385, 176);
            durum.Name = "durum";
            durum.Size = new Size(52, 20);
            durum.TabIndex = 6;
            durum.Text = "durum";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(472, 140);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 7;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(472, 176);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 8;
            label6.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 360);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(durum);
            Controls.Add(ortalama);
            Controls.Add(hesapla);
            Controls.Add(final);
            Controls.Add(vize);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label vize;
        private Label final;
        private Button hesapla;
        private Label ortalama;
        private Label durum;
        private Label label5;
        private Label label6;
    }
}
