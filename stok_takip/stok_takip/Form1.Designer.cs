namespace stok_takip
{
    partial class FormMagazaSatis
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
            buttonMusteriEkleme = new Button();
            buttonMusteriListeleme = new Button();
            buttonUrunEkleme = new Button();
            buttonUrunListeleme = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtbarkodno = new TextBox();
            button1 = new Button();
            label2 = new Label();
            textTutar = new TextBox();
            button2 = new Button();
            label3 = new Label();
            textUrunadi = new TextBox();
            textMiktari = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textFiyat = new TextBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonMusteriEkleme
            // 
            buttonMusteriEkleme.Location = new Point(44, 101);
            buttonMusteriEkleme.Name = "buttonMusteriEkleme";
            buttonMusteriEkleme.Size = new Size(160, 85);
            buttonMusteriEkleme.TabIndex = 0;
            buttonMusteriEkleme.Text = "Musteri Ekleme";
            buttonMusteriEkleme.UseVisualStyleBackColor = true;
            buttonMusteriEkleme.Click += buttonMusteriEkleme_Click;
            // 
            // buttonMusteriListeleme
            // 
            buttonMusteriListeleme.Location = new Point(44, 196);
            buttonMusteriListeleme.Name = "buttonMusteriListeleme";
            buttonMusteriListeleme.Size = new Size(160, 85);
            buttonMusteriListeleme.TabIndex = 1;
            buttonMusteriListeleme.Text = "Musteri Listeleme";
            buttonMusteriListeleme.UseVisualStyleBackColor = true;
            buttonMusteriListeleme.Click += buttonMusteriListeleme_Click;
            // 
            // buttonUrunEkleme
            // 
            buttonUrunEkleme.Location = new Point(44, 310);
            buttonUrunEkleme.Name = "buttonUrunEkleme";
            buttonUrunEkleme.Size = new Size(160, 85);
            buttonUrunEkleme.TabIndex = 2;
            buttonUrunEkleme.Text = "Urun Ekleme";
            buttonUrunEkleme.UseVisualStyleBackColor = true;
            buttonUrunEkleme.Click += buttonUrunEkleme_Click;
            // 
            // buttonUrunListeleme
            // 
            buttonUrunListeleme.Location = new Point(44, 417);
            buttonUrunListeleme.Name = "buttonUrunListeleme";
            buttonUrunListeleme.Size = new Size(160, 85);
            buttonUrunListeleme.TabIndex = 3;
            buttonUrunListeleme.Text = "Urun Listeleme";
            buttonUrunListeleme.UseVisualStyleBackColor = true;
            buttonUrunListeleme.Click += buttonUrunListeleme_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(315, 223);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(758, 331);
            dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 30);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 6;
            label1.Text = "Barkod No";
            // 
            // txtbarkodno
            // 
            txtbarkodno.Location = new Point(145, 23);
            txtbarkodno.Name = "txtbarkodno";
            txtbarkodno.Size = new Size(179, 27);
            txtbarkodno.TabIndex = 7;
            txtbarkodno.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(813, 631);
            button1.Name = "button1";
            button1.Size = new Size(155, 38);
            button1.TabIndex = 8;
            button1.Text = "Satış Yap";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(656, 580);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 9;
            label2.Text = "Toplam Tutar";
            // 
            // textTutar
            // 
            textTutar.Location = new Point(813, 573);
            textTutar.Name = "textTutar";
            textTutar.Size = new Size(139, 27);
            textTutar.TabIndex = 10;
            textTutar.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(748, 101);
            button2.Name = "button2";
            button2.Size = new Size(162, 51);
            button2.TabIndex = 11;
            button2.Text = "Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 65);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 13;
            label3.Text = "Ürün Adı";
            // 
            // textUrunadi
            // 
            textUrunadi.Location = new Point(145, 56);
            textUrunadi.Name = "textUrunadi";
            textUrunadi.Size = new Size(179, 27);
            textUrunadi.TabIndex = 14;
            // 
            // textMiktari
            // 
            textMiktari.Location = new Point(145, 93);
            textMiktari.Name = "textMiktari";
            textMiktari.Size = new Size(179, 27);
            textMiktari.TabIndex = 15;
            textMiktari.Text = "1";
            textMiktari.TextChanged += textMiktari_TextChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 96);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 16;
            label4.Text = "Miktarı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 130);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 17;
            label5.Text = "Fiyatı";
            // 
            // textFiyat
            // 
            textFiyat.Location = new Point(145, 123);
            textFiyat.Name = "textFiyat";
            textFiyat.Size = new Size(179, 27);
            textFiyat.TabIndex = 18;
            textFiyat.TextChanged += textFiyat_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textFiyat);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textMiktari);
            groupBox1.Controls.Add(textUrunadi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtbarkodno);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(325, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 163);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // FormMagazaSatis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1175, 737);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(textTutar);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(buttonUrunListeleme);
            Controls.Add(buttonMusteriEkleme);
            Controls.Add(buttonUrunEkleme);
            Controls.Add(buttonMusteriListeleme);
            Name = "FormMagazaSatis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Magaza Satis Sayfasi";
            Load += FormMagazaSatis_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMusteriEkleme;
        private Button buttonMusteriListeleme;
        private Button buttonUrunEkleme;
        private Button buttonUrunListeleme;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtbarkodno;
        private Button button1;
        private Label label2;
        private TextBox textTutar;
        private Button button2;
        private Label label3;
        private TextBox textUrunadi;
        private TextBox textMiktari;
        private Label label4;
        private Label label5;
        private TextBox textFiyat;
        private GroupBox groupBox1;
    }
}