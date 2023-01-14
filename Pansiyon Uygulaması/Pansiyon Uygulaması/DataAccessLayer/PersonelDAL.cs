using Pansiyon_Uygulaması.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pansiyon_Uygulaması.DataAccessLayer
{
    public class PersonelDAL : IRepository<Personel>
    {
        public bool Ekle(Personel entity)
        {

            SqlCommand komut = new SqlCommand("insert into Personeller(Adi, Soyadi, KimlikNo, KullaniciAdi, Sifre, Telefon, Adres) Values(@adi, @soyadi, @kimlikno, @kullaniciadi, @sifre, @telefon, @adres)", Tools.Baglanti);
            komut.Parameters.AddWithValue("@adi", entity.Adi);
            komut.Parameters.AddWithValue("@soyadi", entity.Soyadi);
            komut.Parameters.AddWithValue("@kimlikno", entity.KimlikNo);
            komut.Parameters.AddWithValue("@kullaniciadi", entity.KullaniciAdi);
            komut.Parameters.AddWithValue("@sifre", entity.Sifre);
            komut.Parameters.AddWithValue("@telefon", entity.Telefon);
            komut.Parameters.AddWithValue("@adres", entity.Adres);

            return Tools.ExecuteNonQuery(komut);
        }

        public bool Guncelle(Personel entity)
        {

            SqlCommand komut = new SqlCommand("Update Personeller set Adi=@adi, Soyadi=@soyadi, KimlikNo=@kimlikno, KullaniciAdi=@kullaniciadi, Sifre=@sifre, Telefon=@telefon, Adres=@adres, GuncellemeTarihi=@guncellemetarihi where Id = @id", Tools.Baglanti);

            komut.Parameters.AddWithValue("@id", entity.Id);
            komut.Parameters.AddWithValue("@adi", entity.Adi);
            komut.Parameters.AddWithValue("@soyadi", entity.Soyadi);
            komut.Parameters.AddWithValue("@kimlikno", entity.KimlikNo);
            komut.Parameters.AddWithValue("@kullaniciadi", entity.KullaniciAdi);
            komut.Parameters.AddWithValue("@sifre", entity.Sifre);
            komut.Parameters.AddWithValue("@telefon", entity.Telefon);
            komut.Parameters.AddWithValue("@adres", entity.Adres);
            komut.Parameters.AddWithValue("guncellemetarihi", entity.GuncellemeTarihi);

            return Tools.ExecuteNonQuery(komut);
        }

        public DataTable Listele()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("PersonelListele", Tools.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }

        public bool Sil(int id)
        {
            SqlCommand command = new SqlCommand("Delete from Personeller where Id = @id", Tools.Baglanti);
            command.Parameters.AddWithValue("@id", id);

            return Tools.ExecuteNonQuery(command);

        }
    }
}
