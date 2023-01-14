using Pansiyon_Uygulaması.DataAccessLayer;
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
    public partial class FrmKullaniciGiris : Form
    {
        public FrmKullaniciGiris()
        {
            InitializeComponent();
        }

       

        private void btnGiris_Click(object sender, EventArgs e)
        {

            KullaniciKontrolDal kullanici = new KullaniciKontrolDal();

            if(kullanici.KullaniciKontrol(tbxKullanici.Text, tbxSifre.Text))
            {
                FrmAnasayfa anasayfa = new FrmAnasayfa();
                anasayfa.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da Şifre hatalı. Lütfen tekrar deneyiniz.","Hatalı Giriş", MessageBoxButtons.OK,MessageBoxIcon.Error);
                tbxKullanici.Clear();
                tbxSifre.Clear();


            }


          
        }

        private void tbxKullanici_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
