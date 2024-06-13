namespace stok_takip
{
    partial class MusteriListeme
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
            dataGridView1 = new DataGridView();
            buttonGuncelle = new Button();
            textAdres = new TextBox();
            textTelefon = new TextBox();
            textAdSoyad = new TextBox();
            textMusteriID = new TextBox();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button = new Button();
            textMusteriIDara = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(269, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(595, 304);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // buttonGuncelle
            // 
            buttonGuncelle.Location = new Point(130, 269);
            buttonGuncelle.Name = "buttonGuncelle";
            buttonGuncelle.Size = new Size(111, 46);
            buttonGuncelle.TabIndex = 24;
            buttonGuncelle.Text = "Guncelle";
            buttonGuncelle.UseVisualStyleBackColor = true;
            buttonGuncelle.Click += buttonGuncelle_Click;
            // 
            // textAdres
            // 
            textAdres.Location = new Point(116, 197);
            textAdres.Name = "textAdres";
            textAdres.Size = new Size(125, 27);
            textAdres.TabIndex = 23;
            // 
            // textTelefon
            // 
            textTelefon.Location = new Point(116, 157);
            textTelefon.Name = "textTelefon";
            textTelefon.Size = new Size(125, 27);
            textTelefon.TabIndex = 22;
            // 
            // textAdSoyad
            // 
            textAdSoyad.Location = new Point(116, 124);
            textAdSoyad.Name = "textAdSoyad";
            textAdSoyad.Size = new Size(125, 27);
            textAdSoyad.TabIndex = 21;
            // 
            // textMusteriID
            // 
            textMusteriID.Location = new Point(116, 91);
            textMusteriID.Name = "textMusteriID";
            textMusteriID.Size = new Size(125, 27);
            textMusteriID.TabIndex = 20;
            textMusteriID.TextChanged += textMusteriID_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 197);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 19;
            label7.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 164);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 18;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 131);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 17;
            label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 98);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 16;
            label1.Text = "MusteriID";
            // 
            // button
            // 
            button.Location = new Point(130, 331);
            button.Name = "button";
            button.Size = new Size(111, 39);
            button.TabIndex = 25;
            button.Text = "Sil";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // textMusteriIDara
            // 
            textMusteriIDara.Location = new Point(600, 35);
            textMusteriIDara.Name = "textMusteriIDara";
            textMusteriIDara.Size = new Size(144, 27);
            textMusteriIDara.TabIndex = 26;
            textMusteriIDara.TextChanged += textMusteriIDara_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(466, 38);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 27;
            label4.Text = "Musteri ID Ara";
            // 
            // MusteriListeme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(888, 525);
            Controls.Add(label4);
            Controls.Add(textMusteriIDara);
            Controls.Add(button);
            Controls.Add(buttonGuncelle);
            Controls.Add(textAdres);
            Controls.Add(textTelefon);
            Controls.Add(textAdSoyad);
            Controls.Add(textMusteriID);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "MusteriListeme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Musteri Listeme Sayfasi";
            Load += MusteriListeme_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonGuncelle;
        private TextBox textAdres;
        private TextBox textTelefon;
        private TextBox textAdSoyad;
        private TextBox textMusteriID;
        private Label label7;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button;
        private TextBox textMusteriIDara;
        private Label label4;
    }
}