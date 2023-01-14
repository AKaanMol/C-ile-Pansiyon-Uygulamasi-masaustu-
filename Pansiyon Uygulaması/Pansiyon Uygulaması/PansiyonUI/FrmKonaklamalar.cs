using Pansiyon_Uygulaması.DataAccessLayer;
using Pansiyon_Uygulaması.EntityLayer.Entities;
using Pansiyon_Uygulaması.EntityLayer.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_Uygulaması.PansiyonUI
{
    public partial class FrmKonaklamalar : Form
    {
        KonaklamaDal _konaklamaDal = new KonaklamaDal();
        public string AdiSoyadi { get; set; }
        public string MusateriId { get; set; }
        Oda oda;
        public FrmKonaklamalar()
        {
            InitializeComponent();
        }
        

     

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxmusteriAdiSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxOdaId.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxodaNo.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbxOdaFiyati.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tbxToplamFiyat.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cbxMusiatMİ.Checked =Convert.ToBoolean( dataGridView1.CurrentRow.Cells[9].Value);
            this.MusateriId = dataGridView1.CurrentRow.Cells[1].Value.ToString();



        }
        private void Listele()
        {
            dataGridView1.DataSource = _konaklamaDal.Listele();
        }

        private void frmKonaklamalar_Load(object sender, EventArgs e)
        {
            
            tbxmusteriAdiSoyadi.Text = AdiSoyadi;
            Listele();
            OdaSec();
        }

        private void OdaSec()
        {
            OdaDAL odaDAL = new OdaDAL();
            int pozisyonX=30, pozisyonY=50, sutun = 1;
            for(int i = 0; i < odaDAL.OdaListele().Count; i++)
            {
                MyButton myButton = new MyButton();
                myButton.Oda = odaDAL.OdaListele()[i];
                myButton.Location = new Point(pozisyonX, pozisyonY);
                myButton.Height = 45;
                myButton.Width = 45;
                myButton.Text = odaDAL.OdaListele()[i].OdaNo.ToString();
                myButton.Name = odaDAL.OdaListele()[i].Id.ToString();

                myButton.Click += new EventHandler(SeciliButon);

                gbxOdalar.Controls.Add(myButton);

                if(odaDAL.OdaListele()[i].MusaitMi)
                {

                    myButton.BackColor = Color.Green;

                }
                else
                {
                    myButton.BackColor = Color.Red;
                    myButton.Enabled = false;//aynı zamanda buton tıklanamaz olacak
                }

                if(sutun<4)
                {
                    pozisyonX += 46;
                    sutun++;
                }
                else
                {
                    pozisyonX = 30;
                    pozisyonY +=46;
                    sutun = 1;
                        
                }

            }

            


        }
        private void SeciliButon(Object sender, EventArgs eventArgs)
        {
            MyButton dinamikButton = (sender as MyButton);
            tbxodaNo.Text = dinamikButton.Oda.OdaNo;
            tbxOdaId.Text = dinamikButton.Oda.Id.ToString();
            tbxOdaFiyati.Text = dinamikButton.Oda.OdaFiyati.ToString();
            oda = dinamikButton.Oda;

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            FiyatHesapla();
        }
        private void FiyatHesapla()
        {
            if(tbxOdaFiyati.Text != null && tbxOdaFiyati.Text!="" && dateTimePicker1.Text != dateTimePicker2.Text)
            {
                TimeSpan gunSayisi;
                gunSayisi = DateTime.Parse(dateTimePicker2.Text) - DateTime.Parse(dateTimePicker1.Text);
               tbxToplamFiyat.Text = (gunSayisi.TotalDays * Convert.ToDouble(tbxOdaFiyati.Text)).ToString();


            }

        }

        private void btnFormuTemizle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }

        private void FormTemizle()
        {
            foreach (Control item in Konaklamalar.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Name != "tbxmusteriAdiSoyadi")
                        item.Text = "";

                }
            }
            dateTimePicker1.Text = DateTime.Now.ToString();
            dateTimePicker2.Text = DateTime.Now.ToString();
            cbxMusiatMİ.Checked =false;


        }

        private void cbxMusiatMİ_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxMusiatMİ.Checked== true)
            {
                cbxMusiatMİ.Text = "Dolu";
            }
            else
            {
                cbxMusiatMİ.Text = "Boş";
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Konaklama konaklama = new Konaklama()
            {
                MusteriId = Convert.ToInt32(this.MusateriId),
                OdaId = Convert.ToInt32(tbxOdaId.Text),
                ToplamFiyat = Convert.ToDouble(tbxToplamFiyat.Text),
                GirisTarihi = Convert.ToDateTime(dateTimePicker1.Text),
                CikisTarihi = Convert.ToDateTime(dateTimePicker2.Text),
                AktifMi =cbxMusiatMİ.Checked
            };
            OdaDAL odaDAL = new OdaDAL();
            oda.MusaitMi = false;
            oda.GuncellemeTarihi = DateTime.Now;
            

            if (_konaklamaDal.Ekle(konaklama)&& odaDAL.Guncelle(oda))
            {
                MessageBox.Show("Konaklama başarılı bir şekilde kaydedildi.");
                Listele();
                FormTemizle();
                gbxOdalar.Controls.Clear();
                OdaSec();
            }
            else
            {
                MessageBox.Show("Veriler kaydedilirken hata oluştu.");
            }
       
    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (tbxId.Text != null && tbxId.Text != "")
            {
                OdaDAL odaDAL = new OdaDAL();
                if (oda == null)
                {
                    oda = new Oda();
                    oda.Id = Convert.ToInt32(tbxOdaId.Text);
                }
                oda.MusaitMi = true;
                if (odaDAL.DurumGuncelle(oda))
                    MessageBox.Show("oda guncellendi");
                MessageBox.Show("konaklama silindi");
                Listele();
                FormTemizle();
                gbxOdalar.Controls.Clear();
                OdaSec();
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Konaklama konaklama = new Konaklama()
            {
                Id = Convert.ToInt32(tbxId.Text),
                MusteriId = Convert.ToInt32(this.MusateriId),
                OdaId = Convert.ToInt32(tbxOdaId.Text),
                ToplamFiyat = Convert.ToDouble(tbxToplamFiyat.Text),
                GirisTarihi = Convert.ToDateTime(dateTimePicker1.Text),
                CikisTarihi = Convert.ToDateTime(dateTimePicker2.Text),
                AktifMi = cbxMusiatMİ.Checked,
                GuncellemeTarihi = DateTime.Now
            };

            if (_konaklamaDal.Guncelle(konaklama))
            {
                if (konaklama.AktifMi == false)
                {
                    OdaDAL odaDal = new OdaDAL();
                    if (oda == null)
                    {
                        oda = new Oda();
                        oda.Id = konaklama.OdaId;
                    }
                    oda.MusaitMi = true;
                    if (odaDal.DurumGuncelle(oda))
                    {
                        MessageBox.Show("Oda güncellendi");
                    }
                }
                MessageBox.Show("Konaklama başarılı bir şekilde güncellendi");
                Listele();
                FormTemizle();
                gbxOdalar.Controls.Clear();
                OdaSec();

            }

        }
    }
    
}
