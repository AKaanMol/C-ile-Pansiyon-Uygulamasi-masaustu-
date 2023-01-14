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
    public partial class FrmMusteriler : Form
    {
        MusteriDAL _musteriDAL = new MusteriDAL();

        public FrmMusteriler()
        {
            InitializeComponent();
        }
        private void frmMusteriler_Load_1(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            dataGridView1.DataSource = _musteriDAL.Listele();
            
        }
        
        private void btnFormuTemizle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }
        private void FormTemizle()
        {
            tbxId.Clear();
            tbxAdi.Clear();
            tbxSoyadi.Clear();
            tbxKimlik.Clear();            
            mtbxTelefon.Clear();
            tbxEmail.Clear();
            tbxAdres.Clear();
            cbxCinsiyet.Text = "";
            
        }

        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri()
            {
                Adi = tbxAdi.Text,
                Soyadi = tbxSoyadi.Text,
                KimlikNo = tbxKimlik.Text,
                Cinsiyet = cbxCinsiyet.Text,
                Telefon = mtbxTelefon.Text,
                Email = tbxEmail.Text,
                Adres = tbxAdres.Text,
            };
            if (_musteriDAL.Ekle(musteri))
            {
                MessageBox.Show("Müşteri başarılı bir şekilde kaydedildi.");
                Listele();
                FormTemizle();
            }
            else
            {
                MessageBox.Show("Veriler kaydedilirkn hata oluştu.");
            }
                                              
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            tbxAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
            tbxSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
            tbxKimlik.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim();
            cbxCinsiyet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim();
            mtbxTelefon.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim();
            tbxAdres.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString().Trim();
            tbxEmail.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString().Trim();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri()
            {
                Id = Convert.ToInt32(tbxId.Text),
                Adi = tbxAdi.Text,
                Soyadi = tbxSoyadi.Text,
                KimlikNo = tbxKimlik.Text,
                Cinsiyet = cbxCinsiyet.Text,
                Telefon = mtbxTelefon.Text,
                Adres = tbxAdres.Text,
                Email = tbxEmail.Text,
                GuncellemeTarihi = DateTime.Now
            };
            if (_musteriDAL.Guncelle(musteri))
            {
                MessageBox.Show("Müşteri başarılı bir şekilde güncellendi.");
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
            if (tbxId.Text != null && tbxId.Text != "")
            {
                if (_musteriDAL.Sil(Convert.ToInt32(tbxId.Text)))
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

        private void btnKonaklamaEkle_Click(object sender, EventArgs e)
        {
            FrmKonaklamalar frmKonaklamalar= new FrmKonaklamalar();
            frmKonaklamalar.AdiSoyadi = tbxAdi.Text.Trim() + " " + tbxSoyadi.Text.Trim();
            frmKonaklamalar.MusateriId = tbxId.Text.Trim();

            frmKonaklamalar.ShowDialog();
        }

        private void tbxismegoref_TextChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void Filtrele()
        {
            DataView dataView = new DataView();
            dataView = _musteriDAL.Listele().DefaultView;

            string filtre = "";
            if (tbxismegoref.Text != "" && tbxismegoref.Text != null)
            {
                filtre = "Adi like '" + tbxismegoref.Text + "%'";
            }
            if (tbxismegoref.Text != "" && tbxismegoref.Text != null && tbxsoyismegoref.Text != "" && tbxsoyismegoref.Text != null)
            {
                filtre += " and ";
            }

            if (tbxsoyismegoref.Text != "" && tbxsoyismegoref.Text != null)
            {
                filtre += "Soyadi like '" + tbxsoyismegoref.Text + "%'";
            }


            dataView.RowFilter = filtre;
            dataGridView1.DataSource = dataView;
        }

        private void tbxsoyismegoref_TextChanged(object sender, EventArgs e)
        {
            Filtrele();
        }
    }
}
