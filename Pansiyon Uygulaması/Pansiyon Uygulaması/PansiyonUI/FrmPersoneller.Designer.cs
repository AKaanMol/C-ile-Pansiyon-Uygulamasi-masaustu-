namespace Pansiyon_Uygulaması.PansiyonUI
{
    partial class FrmPersoneller
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
            this.tbxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAdi = new System.Windows.Forms.TextBox();
            this.tbxSoyadi = new System.Windows.Forms.TextBox();
            this.tbxKimlik = new System.Windows.Forms.TextBox();
            this.tbxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAdres = new System.Windows.Forms.TextBox();
            this.mtbxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnFormTemizle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxIsmeGoreFiltrele = new System.Windows.Forms.TextBox();
            this.tbxSoyadaGoreFiltrele = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1084, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tbxId
            // 
            this.tbxId.Enabled = false;
            this.tbxId.Location = new System.Drawing.Point(122, 15);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(128, 22);
            this.tbxId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel Id";
            // 
            // tbxAdi
            // 
            this.tbxAdi.Location = new System.Drawing.Point(122, 43);
            this.tbxAdi.Name = "tbxAdi";
            this.tbxAdi.Size = new System.Drawing.Size(128, 22);
            this.tbxAdi.TabIndex = 2;
            // 
            // tbxSoyadi
            // 
            this.tbxSoyadi.Location = new System.Drawing.Point(122, 71);
            this.tbxSoyadi.Name = "tbxSoyadi";
            this.tbxSoyadi.Size = new System.Drawing.Size(128, 22);
            this.tbxSoyadi.TabIndex = 2;
            // 
            // tbxKimlik
            // 
            this.tbxKimlik.Location = new System.Drawing.Point(122, 99);
            this.tbxKimlik.MaxLength = 11;
            this.tbxKimlik.Name = "tbxKimlik";
            this.tbxKimlik.Size = new System.Drawing.Size(128, 22);
            this.tbxKimlik.TabIndex = 2;
            // 
            // tbxKullaniciAdi
            // 
            this.tbxKullaniciAdi.Location = new System.Drawing.Point(122, 155);
            this.tbxKullaniciAdi.Name = "tbxKullaniciAdi";
            this.tbxKullaniciAdi.Size = new System.Drawing.Size(128, 22);
            this.tbxKullaniciAdi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "T.C Kimlik No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Kullanıcı Adı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Sifre";
            // 
            // tbxSifre
            // 
            this.tbxSifre.Location = new System.Drawing.Point(122, 183);
            this.tbxSifre.Name = "tbxSifre";
            this.tbxSifre.Size = new System.Drawing.Size(128, 22);
            this.tbxSifre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adres";
            // 
            // tbxAdres
            // 
            this.tbxAdres.Location = new System.Drawing.Point(122, 211);
            this.tbxAdres.Multiline = true;
            this.tbxAdres.Name = "tbxAdres";
            this.tbxAdres.Size = new System.Drawing.Size(180, 71);
            this.tbxAdres.TabIndex = 2;
            // 
            // mtbxTelefon
            // 
            this.mtbxTelefon.Location = new System.Drawing.Point(122, 128);
            this.mtbxTelefon.Mask = "(999) 000-00 00";
            this.mtbxTelefon.Name = "mtbxTelefon";
            this.mtbxTelefon.Size = new System.Drawing.Size(128, 22);
            this.mtbxTelefon.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.ForeColor = System.Drawing.Color.Black;
            this.btnEkle.Location = new System.Drawing.Point(311, 12);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(155, 35);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(311, 58);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(155, 35);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(311, 104);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(155, 35);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnFormTemizle
            // 
            this.btnFormTemizle.Location = new System.Drawing.Point(311, 155);
            this.btnFormTemizle.Name = "btnFormTemizle";
            this.btnFormTemizle.Size = new System.Drawing.Size(155, 35);
            this.btnFormTemizle.TabIndex = 4;
            this.btnFormTemizle.Text = "Formu Temizle";
            this.btnFormTemizle.UseVisualStyleBackColor = true;
            this.btnFormTemizle.Click += new System.EventHandler(this.btnFormTemizle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "İsme Göre Filtrele";
            // 
            // tbxIsmeGoreFiltrele
            // 
            this.tbxIsmeGoreFiltrele.Location = new System.Drawing.Point(461, 260);
            this.tbxIsmeGoreFiltrele.Name = "tbxIsmeGoreFiltrele";
            this.tbxIsmeGoreFiltrele.Size = new System.Drawing.Size(123, 22);
            this.tbxIsmeGoreFiltrele.TabIndex = 6;
            this.tbxIsmeGoreFiltrele.TextChanged += new System.EventHandler(this.tbxIsmeGoreFiltrele_TextChanged);
            // 
            // tbxSoyadaGoreFiltrele
            // 
            this.tbxSoyadaGoreFiltrele.Location = new System.Drawing.Point(599, 260);
            this.tbxSoyadaGoreFiltrele.Name = "tbxSoyadaGoreFiltrele";
            this.tbxSoyadaGoreFiltrele.Size = new System.Drawing.Size(123, 22);
            this.tbxSoyadaGoreFiltrele.TabIndex = 7;
            this.tbxSoyadaGoreFiltrele.TextChanged += new System.EventHandler(this.tbxSoyadaGoreFiltrele_TextChanged);
            // 
            // frmPersoneller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1108, 450);
            this.Controls.Add(this.tbxSoyadaGoreFiltrele);
            this.Controls.Add(this.tbxIsmeGoreFiltrele);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnFormTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.mtbxTelefon);
            this.Controls.Add(this.tbxAdres);
            this.Controls.Add(this.tbxSifre);
            this.Controls.Add(this.tbxKullaniciAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxKimlik);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbxSoyadi);
            this.Controls.Add(this.tbxAdi);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPersoneller";
            this.Text = "frmPersoneller";
            this.Load += new System.EventHandler(this.frmPersoneller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxAdi;
        private System.Windows.Forms.TextBox tbxSoyadi;
        private System.Windows.Forms.TextBox tbxKimlik;
        private System.Windows.Forms.TextBox tbxKullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAdres;
        private System.Windows.Forms.MaskedTextBox mtbxTelefon;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnFormTemizle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxIsmeGoreFiltrele;
        private System.Windows.Forms.TextBox tbxSoyadaGoreFiltrele;
    }
}