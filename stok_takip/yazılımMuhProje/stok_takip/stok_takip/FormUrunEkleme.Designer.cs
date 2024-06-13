namespace stok_takip
{
    partial class FormUrunEkleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            textKategori = new TextBox();
            label1 = new Label();
            button1 = new Button();
            textFiyati = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textMiktari = new TextBox();
            textUrunAdi = new TextBox();
            textBarkodNo = new TextBox();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textKategori);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textFiyati);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textMiktari);
            groupBox2.Controls.Add(textUrunAdi);
            groupBox2.Controls.Add(textBarkodNo);
            groupBox2.Location = new Point(62, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(392, 301);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Urun Islemleri";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // textKategori
            // 
            textKategori.Location = new Point(154, 85);
            textKategori.Name = "textKategori";
            textKategori.Size = new Size(177, 27);
            textKategori.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 88);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 9;
            label1.Text = "Kategori";
            // 
            // button1
            // 
            button1.Location = new Point(114, 239);
            button1.Name = "button1";
            button1.Size = new Size(175, 39);
            button1.TabIndex = 8;
            button1.Text = "Ekle/Guncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textFiyati
            // 
            textFiyati.Location = new Point(154, 187);
            textFiyati.Name = "textFiyati";
            textFiyati.Size = new Size(177, 27);
            textFiyati.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 187);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 6;
            label8.Text = "Fiyati";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 151);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 5;
            label6.Text = "Miktari";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 118);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 4;
            label5.Text = "Urun Adi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 55);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 3;
            label4.Text = "Barkod No";
            // 
            // textMiktari
            // 
            textMiktari.Location = new Point(154, 151);
            textMiktari.Name = "textMiktari";
            textMiktari.Size = new Size(177, 27);
            textMiktari.TabIndex = 2;
            // 
            // textUrunAdi
            // 
            textUrunAdi.Location = new Point(154, 118);
            textUrunAdi.Name = "textUrunAdi";
            textUrunAdi.Size = new Size(177, 27);
            textUrunAdi.TabIndex = 1;
            // 
            // textBarkodNo
            // 
            textBarkodNo.Location = new Point(154, 48);
            textBarkodNo.Name = "textBarkodNo";
            textBarkodNo.Size = new Size(177, 27);
            textBarkodNo.TabIndex = 0;
            // 
            // FormUrunEkleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(581, 346);
            Controls.Add(groupBox2);
            Name = "FormUrunEkleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUrunEkleme";
            Load += FormUrunEkleme_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox textFiyati;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textMiktari;
        private TextBox textUrunAdi;
        private TextBox textBarkodNo;
        private Button button1;
        private TextBox textKategori;
        private Label label1;
    }
}