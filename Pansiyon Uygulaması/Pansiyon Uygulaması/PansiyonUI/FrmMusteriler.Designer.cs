
namespace Pansiyon_Uygulaması.PansiyonUI
{
    partial class FrmMusteriler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSoyadi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxKimlik = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxAdres = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnFormuTemizle = new System.Windows.Forms.Button();
            this.mtbxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.tbxCinsiyet = new System.Windows.Forms.Label();
            this.cbxCinsiyet = new System.Windows.Forms.ComboBox();
            this.btnKonaklamaEkle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxismegoref = new System.Windows.Forms.TextBox();
            this.tbxsoyismegoref = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 288);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1045, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri Id";
            // 
            // tbxId
            // 
            this.tbxId.Enabled = false;
            this.tbxId.Location = new System.Drawing.Point(133, 4);
            this.tbxId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(143, 22);
            this.tbxId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad";
            // 
            // tbxAdi
            // 
            this.tbxAdi.Location = new System.Drawing.Point(133, 32);
            this.tbxAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAdi.Name = "tbxAdi";
            this.tbxAdi.Size = new System.Drawing.Size(143, 22);
            this.tbxAdi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyad";
            // 
            // tbxSoyadi
            // 
            this.tbxSoyadi.Location = new System.Drawing.Point(133, 60);
            this.tbxSoyadi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSoyadi.Name = "tbxSoyadi";
            this.tbxSoyadi.Size = new System.Drawing.Size(143, 22);
            this.tbxSoyadi.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "T.C Kimlik No";
            // 
            // tbxKimlik
            // 
            this.tbxKimlik.Location = new System.Drawing.Point(133, 89);
            this.tbxKimlik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxKimlik.MaxLength = 11;
            this.tbxKimlik.Name = "tbxKimlik";
            this.tbxKimlik.Size = new System.Drawing.Size(143, 22);
            this.tbxKimlik.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "E-mail";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(133, 176);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(143, 22);
            this.tbxEmail.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Adres";
            // 
            // tbxAdres
            // 
            this.tbxAdres.Location = new System.Drawing.Point(133, 207);
            this.tbxAdres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAdres.Multiline = true;
            this.tbxAdres.Name = "tbxAdres";
            this.tbxAdres.Size = new System.Drawing.Size(211, 78);
            this.tbxAdres.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(345, 18);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(135, 33);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(345, 58);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(135, 33);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(345, 98);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(135, 33);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnFormuTemizle
            // 
            this.btnFormuTemizle.Location = new System.Drawing.Point(345, 137);
            this.btnFormuTemizle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFormuTemizle.Name = "btnFormuTemizle";
            this.btnFormuTemizle.Size = new System.Drawing.Size(135, 33);
            this.btnFormuTemizle.TabIndex = 3;
            this.btnFormuTemizle.Text = "Formu Temizle";
            this.btnFormuTemizle.UseVisualStyleBackColor = true;
            this.btnFormuTemizle.Click += new System.EventHandler(this.btnFormuTemizle_Click);
            // 
            // mtbxTelefon
            // 
            this.mtbxTelefon.Location = new System.Drawing.Point(133, 148);
            this.mtbxTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbxTelefon.Mask = "(999) 000-00 00";
            this.mtbxTelefon.Name = "mtbxTelefon";
            this.mtbxTelefon.Size = new System.Drawing.Size(143, 22);
            this.mtbxTelefon.TabIndex = 4;
            // 
            // tbxCinsiyet
            // 
            this.tbxCinsiyet.AutoSize = true;
            this.tbxCinsiyet.Location = new System.Drawing.Point(35, 121);
            this.tbxCinsiyet.Name = "tbxCinsiyet";
            this.tbxCinsiyet.Size = new System.Drawing.Size(57, 17);
            this.tbxCinsiyet.TabIndex = 1;
            this.tbxCinsiyet.Text = "Cinsiyet";
            // 
            // cbxCinsiyet
            // 
            this.cbxCinsiyet.FormattingEnabled = true;
            this.cbxCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cbxCinsiyet.Location = new System.Drawing.Point(133, 119);
            this.cbxCinsiyet.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCinsiyet.Name = "cbxCinsiyet";
            this.cbxCinsiyet.Size = new System.Drawing.Size(143, 24);
            this.cbxCinsiyet.TabIndex = 6;
            this.cbxCinsiyet.TabStop = false;
            // 
            // btnKonaklamaEkle
            // 
            this.btnKonaklamaEkle.Location = new System.Drawing.Point(363, 225);
            this.btnKonaklamaEkle.Name = "btnKonaklamaEkle";
            this.btnKonaklamaEkle.Size = new System.Drawing.Size(117, 36);
            this.btnKonaklamaEkle.TabIndex = 7;
            this.btnKonaklamaEkle.Text = "Konaklama Ekle";
            this.btnKonaklamaEkle.UseVisualStyleBackColor = true;
            this.btnKonaklamaEkle.Click += new System.EventHandler(this.btnKonaklamaEkle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(734, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "İsme Göre Filtrele";
            // 
            // tbxismegoref
            // 
            this.tbxismegoref.Location = new System.Drawing.Point(872, 263);
            this.tbxismegoref.Name = "tbxismegoref";
            this.tbxismegoref.Size = new System.Drawing.Size(100, 22);
            this.tbxismegoref.TabIndex = 9;
            this.tbxismegoref.TextChanged += new System.EventHandler(this.tbxismegoref_TextChanged);
            // 
            // tbxsoyismegoref
            // 
            this.tbxsoyismegoref.Location = new System.Drawing.Point(978, 263);
            this.tbxsoyismegoref.Name = "tbxsoyismegoref";
            this.tbxsoyismegoref.Size = new System.Drawing.Size(100, 22);
            this.tbxsoyismegoref.TabIndex = 10;
            this.tbxsoyismegoref.TextChanged += new System.EventHandler(this.tbxsoyismegoref_TextChanged);
            // 
            // frmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1109, 450);
            this.Controls.Add(this.tbxsoyismegoref);
            this.Controls.Add(this.tbxismegoref);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnKonaklamaEkle);
            this.Controls.Add(this.cbxCinsiyet);
            this.Controls.Add(this.mtbxTelefon);
            this.Controls.Add(this.btnFormuTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.tbxAdres);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxCinsiyet);
            this.Controls.Add(this.tbxKimlik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxSoyadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMusteriler";
            this.Text = "frmMusteriler";
            this.Load += new System.EventHandler(this.frmMusteriler_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxSoyadi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxKimlik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxAdres;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnFormuTemizle;
        private System.Windows.Forms.MaskedTextBox mtbxTelefon;
        private System.Windows.Forms.Label tbxCinsiyet;
        private System.Windows.Forms.ComboBox cbxCinsiyet;
        private System.Windows.Forms.Button btnKonaklamaEkle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxismegoref;
        private System.Windows.Forms.TextBox tbxsoyismegoref;
    }
}