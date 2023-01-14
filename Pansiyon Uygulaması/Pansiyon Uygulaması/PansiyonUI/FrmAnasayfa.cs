using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_Uygulaması.PansiyonUI
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            DialogResult secim= new DialogResult();
           secim = MessageBox.Show("Çıkmak istediğine emin misin?", "Çıkış", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(secim== DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnPersoneller_Click(object sender, EventArgs e)
        {
            FrmPersoneller personelfrm = new FrmPersoneller();
            personelfrm.MdiParent = this;
            FormGetir(personelfrm);
        }

        private void FormGetir(Form form)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();

        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            FrmMusteriler musterifrm = new FrmMusteriler();
            musterifrm.MdiParent= this;
            FormGetir(musterifrm);
        }

        private void btnKonaklamalar_Click(object sender, EventArgs e)
        {
            FrmKonaklamalar konaklamafrm = new FrmKonaklamalar();
            konaklamafrm.MdiParent=this;
            FormGetir(konaklamafrm);
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            FrmOdalar odalarfrm = new FrmOdalar();
            odalarfrm.MdiParent= this;
            FormGetir(odalarfrm);
        }

        private void Anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
