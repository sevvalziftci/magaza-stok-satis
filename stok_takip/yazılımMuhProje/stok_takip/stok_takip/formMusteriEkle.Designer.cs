namespace stok_takip
{
    partial class formMusteriEkle
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
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textMusteriID = new TextBox();
            textAdSoyad = new TextBox();
            textTelefon = new TextBox();
            textAdres = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 161);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 10;
            label7.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 128);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 9;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 95);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 8;
            label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 62);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 7;
            label1.Text = "MusteriID";
            // 
            // textMusteriID
            // 
            textMusteriID.Location = new Point(161, 55);
            textMusteriID.Name = "textMusteriID";
            textMusteriID.Size = new Size(125, 27);
            textMusteriID.TabIndex = 11;
            // 
            // textAdSoyad
            // 
            textAdSoyad.Location = new Point(161, 88);
            textAdSoyad.Name = "textAdSoyad";
            textAdSoyad.Size = new Size(125, 27);
            textAdSoyad.TabIndex = 12;
            // 
            // textTelefon
            // 
            textTelefon.Location = new Point(161, 121);
            textTelefon.Name = "textTelefon";
            textTelefon.Size = new Size(125, 27);
            textTelefon.TabIndex = 13;
            // 
            // textAdres
            // 
            textAdres.Location = new Point(161, 154);
            textAdres.Name = "textAdres";
            textAdres.Size = new Size(125, 27);
            textAdres.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(130, 231);
            button1.Name = "button1";
            button1.Size = new Size(111, 46);
            button1.TabIndex = 15;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // formMusteriEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(382, 327);
            Controls.Add(button1);
            Controls.Add(textAdres);
            Controls.Add(textTelefon);
            Controls.Add(textAdSoyad);
            Controls.Add(textMusteriID);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formMusteriEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Musteri Ekleme Sayfasi";
            Load += formMusteriEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textMusteriID;
        private TextBox textAdSoyad;
        private TextBox textTelefon;
        private TextBox textAdres;
        private Button button1;
    }
}