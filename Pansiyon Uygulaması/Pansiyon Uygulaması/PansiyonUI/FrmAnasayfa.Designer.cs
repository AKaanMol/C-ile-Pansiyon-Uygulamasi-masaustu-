
namespace Pansiyon_Uygulaması.PansiyonUI
{
    partial class FrmAnasayfa
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnPersoneller = new System.Windows.Forms.Button();
            this.btnMusteriler = new System.Windows.Forms.Button();
            this.btnKonaklamalar = new System.Windows.Forms.Button();
            this.btnOdalar = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnPersoneller);
            this.panelMenu.Controls.Add(this.btncikis);
            this.panelMenu.Controls.Add(this.btnMusteriler);
            this.panelMenu.Controls.Add(this.btnKonaklamalar);
            this.panelMenu.Controls.Add(this.btnOdalar);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 450);
            this.panelMenu.TabIndex = 1;
            // 
            // btnPersoneller
            // 
            this.btnPersoneller.Location = new System.Drawing.Point(42, 29);
            this.btnPersoneller.Name = "btnPersoneller";
            this.btnPersoneller.Size = new System.Drawing.Size(114, 23);
            this.btnPersoneller.TabIndex = 2;
            this.btnPersoneller.Text = "Personeller";
            this.btnPersoneller.UseVisualStyleBackColor = true;
            this.btnPersoneller.Click += new System.EventHandler(this.btnPersoneller_Click);
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Location = new System.Drawing.Point(42, 75);
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(114, 26);
            this.btnMusteriler.TabIndex = 3;
            this.btnMusteriler.Text = "Müşteriler";
            this.btnMusteriler.UseVisualStyleBackColor = true;
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            // 
            // btnKonaklamalar
            // 
            this.btnKonaklamalar.Location = new System.Drawing.Point(42, 133);
            this.btnKonaklamalar.Name = "btnKonaklamalar";
            this.btnKonaklamalar.Size = new System.Drawing.Size(114, 23);
            this.btnKonaklamalar.TabIndex = 4;
            this.btnKonaklamalar.Text = "Konaklamalar";
            this.btnKonaklamalar.UseVisualStyleBackColor = true;
            this.btnKonaklamalar.Click += new System.EventHandler(this.btnKonaklamalar_Click);
            // 
            // btnOdalar
            // 
            this.btnOdalar.Location = new System.Drawing.Point(42, 184);
            this.btnOdalar.Name = "btnOdalar";
            this.btnOdalar.Size = new System.Drawing.Size(114, 24);
            this.btnOdalar.TabIndex = 5;
            this.btnOdalar.Text = "Odalar";
            this.btnOdalar.UseVisualStyleBackColor = true;
            this.btnOdalar.Click += new System.EventHandler(this.btnOdalar_Click);
            // 
            // btncikis
            // 
            this.btncikis.Location = new System.Drawing.Point(42, 385);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(104, 32);
            this.btncikis.TabIndex = 6;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 450);
            this.panel2.TabIndex = 2;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.IsMdiContainer = true;
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Anasayfa_FormClosing);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnPersoneller;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnMusteriler;
        private System.Windows.Forms.Button btnKonaklamalar;
        private System.Windows.Forms.Button btnOdalar;
        private System.Windows.Forms.Panel panel2;
    }
}