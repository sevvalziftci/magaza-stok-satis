namespace stok_takip
{
    partial class FormUrunListele
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
            button1 = new Button();
            textFiyati = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textMiktari = new TextBox();
            textUrunAdi = new TextBox();
            textBarkodNo = new TextBox();
            button3 = new Button();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            textBarkodNoAra = new TextBox();
            label2 = new Label();
            textKategori = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(113, 302);
            button1.Name = "button1";
            button1.Size = new Size(131, 30);
            button1.TabIndex = 17;
            button1.Text = "Guncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textFiyati
            // 
            textFiyati.Location = new Point(113, 233);
            textFiyati.Name = "textFiyati";
            textFiyati.Size = new Size(156, 27);
            textFiyati.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 233);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 15;
            label8.Text = "Fiyati";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 197);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 14;
            label6.Text = "Miktari";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 164);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 13;
            label5.Text = "Urun Adi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 75);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 12;
            label4.Text = "Barkod No";
            // 
            // textMiktari
            // 
            textMiktari.Location = new Point(113, 197);
            textMiktari.Name = "textMiktari";
            textMiktari.Size = new Size(156, 27);
            textMiktari.TabIndex = 11;
            // 
            // textUrunAdi
            // 
            textUrunAdi.Location = new Point(113, 157);
            textUrunAdi.Name = "textUrunAdi";
            textUrunAdi.Size = new Size(156, 27);
            textUrunAdi.TabIndex = 10;
            // 
            // textBarkodNo
            // 
            textBarkodNo.Location = new Point(113, 75);
            textBarkodNo.Name = "textBarkodNo";
            textBarkodNo.Size = new Size(156, 27);
            textBarkodNo.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(113, 353);
            button3.Name = "button3";
            button3.Size = new Size(131, 30);
            button3.TabIndex = 19;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(292, 75);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(626, 332);
            dataGridView2.TabIndex = 20;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(483, 28);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 21;
            label1.Text = "Barkod No Ara";
            // 
            // textBarkodNoAra
            // 
            textBarkodNoAra.Location = new Point(616, 25);
            textBarkodNoAra.Name = "textBarkodNoAra";
            textBarkodNoAra.Size = new Size(171, 27);
            textBarkodNoAra.TabIndex = 22;
            textBarkodNoAra.TextChanged += textBarkodNoAra_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 124);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 23;
            label2.Text = "Kategori";
            // 
            // textKategori
            // 
            textKategori.Location = new Point(113, 117);
            textKategori.Name = "textKategori";
            textKategori.Size = new Size(156, 27);
            textKategori.TabIndex = 24;
            // 
            // FormUrunListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(960, 476);
            Controls.Add(textKategori);
            Controls.Add(label2);
            Controls.Add(textBarkodNoAra);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(textFiyati);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textMiktari);
            Controls.Add(textUrunAdi);
            Controls.Add(textBarkodNo);
            Name = "FormUrunListele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Urun Listeleme Sayfasi";
            Load += FormUrunListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textFiyati;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textMiktari;
        private TextBox textUrunAdi;
        private TextBox textBarkodNo;
        private Button button3;
        private DataGridView dataGridView2;
        private Label label1;
        private TextBox textBarkodNoAra;
        private Label label2;
        private TextBox textKategori;
    }
}