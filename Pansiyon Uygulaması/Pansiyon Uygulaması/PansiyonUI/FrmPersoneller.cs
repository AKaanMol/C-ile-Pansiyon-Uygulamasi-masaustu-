using Pansiyon_Uygulaması.DataAccessLayer;
using Pansiyon_Uygulaması.EntityLayer.Entities;
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
    public partial class FrmPersoneller : Form
    {
        public FrmPersoneller()
        {
            InitializeComponent();
        }
        private void frmMusteriler_Load_1(object sender, EventArgs e)
        {
            Listele();
        }
        private void frmPersoneller_Load(object sender, EventArgs e)
        {
            Listele();
        }
        PersonelDAL _personelDAL = new PersonelDAL();
        private void Listele()
        {
            
            dataGridView1.DataSource = _personelDAL.Listele();
        }

        private void btnFormTemizle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }

        private void FormTemizle()
        {
            tbxId.Clear();
            tbxAdi.Clear();
            tbxSoyadi.Clear();
            tbxKimlik.Clear();
            tbxKullaniciAdi.Clear();
            tbxSifre.Clear();
            tbxAdres.Clear();
            mtbxTelefon.Clear();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel()
            {
                Adi = tbxAdi.Text,
                Soyadi = tbxSoyadi.Text,
                KimlikNo = tbxKimlik.Text,
                KullaniciAdi = tbxKullaniciAdi.Text,
                Sifre = tbxSifre.Text,
                Adres = tbxAdres.Text,
                Telefon = mtbxTelefon.Text,

            };
            if (_personelDAL.Ekle(personel))
            {
                MessageBox.Show("Veriler, veritabanına başarılı bir şekilde kaydedildi.");
                Listele();
                FormTemizle();
            }
            else
            {
                MessageBox.Show("Veriler kaydedilirken bir hata oluştu.");
            }
            
            

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            tbxAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
            tbxSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
            tbxKimlik.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim();
            tbxKullaniciAdi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim();
            tbxSifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim();
            mtbxTelefon.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString().Trim();
            tbxAdres.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString().Trim();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel()
            {
                Id = Convert.ToInt32(tbxId.Text),
                Adi = tbxAdi.Text,
                Soyadi = tbxSoyadi.Text,
                KimlikNo = tbxKimlik.Text,
                KullaniciAdi = tbxKullaniciAdi.Text,
                Sifre = tbxSifre.Text,
                Adres = tbxAdres.Text,
                Telefon = mtbxTelefon.Text,
                GuncellemeTarihi = DateTime.Now
            };
            if (_personelDAL.Guncelle(personel))
            {
                MessageBox.Show("Veriler, veritabanına başarılı bir şekilde güncellendi.");
                Listele();
                FormTemizle();
            }
            else
            {
                MessageBox.Show("Veriler güncellenirken bir hata oluştu.");
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (tbxId.Text!=null && tbxId.Text!="")
            {
                if (_personelDAL.Sil(Convert.ToInt32(tbxId.Text)))
                {
                    MessageBox.Show($"{tbxId.Text} Id'li Kayıt Silindi");
                    Listele();
                    FormTemizle();
                }
                else
                {
                    MessageBox.Show($"{tbxId.Text} Id'li Kayıt silinirken hata oluştu.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Kayıt Seçin");
            }
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxIsmeGoreFiltrele_TextChanged(object sender, EventArgs e)
        {
            Filtrele();

        }

        private void Filtrele()
        {
            DataView dataView = new DataView();
            dataView = _personelDAL.Listele().DefaultView;

            string filtre = "";
            if (tbxIsmeGoreFiltrele.Text != "" && tbxIsmeGoreFiltrele.Text != null)
            {
                filtre = "Adi like '" + tbxIsmeGoreFiltrele.Text + "%'";
            }
            if (tbxIsmeGoreFiltrele.Text != "" && tbxIsmeGoreFiltrele.Text != null && tbxSoyadaGoreFiltrele.Text != "" && tbxSoyadaGoreFiltrele.Text != null)
            {
                filtre += " and ";
            }

            if (tbxSoyadaGoreFiltrele.Text != "" && tbxSoyadaGoreFiltrele.Text != null)
            {
                filtre += "Soyadi like '" + tbxSoyadaGoreFiltrele.Text + "%'";
            }


            dataView.RowFilter = filtre;
            dataGridView1.DataSource = dataView;
        }

        private void tbxSoyadaGoreFiltrele_TextChanged(object sender, EventArgs e)
        {
            Filtrele();
        }
    }
}
