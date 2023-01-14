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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }

        private void Odalar_Load(object sender, EventArgs e)
        {
            Listele();
        }
        OdaDAL _odaDAL = new OdaDAL();
        private void Listele()
        {
            dataGridView1.DataSource = _odaDAL.Listele();
        }

        private void btnFormuTemizle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }
        private void FormTemizle()
        {
            tbxId.Clear();
            tbxOdaNo.Clear();
            tbxOdaFiyati.Clear();       
            checkBox1.Checked = true;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Oda oda = new Oda()
            {
                OdaNo = tbxOdaNo.Text,
                OdaFiyati = Convert.ToDouble (tbxOdaFiyati.Text),
                MusaitMi =checkBox1.Checked

            }; 
            if (_odaDAL.Ekle(oda))
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Oda oda = new Oda()
            {
                Id = Convert.ToInt32( tbxId.Text),
                OdaNo = tbxOdaNo.Text,
                OdaFiyati = Convert.ToDouble (tbxOdaFiyati.Text),
                MusaitMi = checkBox1.Checked,
                GuncellemeTarihi = DateTime.Now                
            };
            if (_odaDAL.Guncelle(oda))
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
            if (tbxId.Text != null && tbxId.Text != "")
            {
                if (_odaDAL.Sil(Convert.ToInt32(tbxId.Text)))
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxOdaNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxOdaFiyati.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            checkBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void cbxMusaitmi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbxismegore_TextChanged(object sender, EventArgs e)
        {
            Filtrele1();
        }

        private void Filtrele()
        {
            Filtrele1();
        }

        private void Filtrele1()
        {
            DataView dataView = new DataView();
            dataView = _odaDAL.Listele().DefaultView;

            string filtre = "";
            if (tbxismegore.Text != "" && tbxismegore.Text != null)
            {
                filtre = "OdaNo like '" + tbxismegore.Text + "%'";
            }




            dataView.RowFilter = filtre;
            dataGridView1.DataSource = dataView;
        }

        private void tbxsoyismegore_TextChanged(object sender, EventArgs e)
        {
            Filtrele1();
        }
    }
}
