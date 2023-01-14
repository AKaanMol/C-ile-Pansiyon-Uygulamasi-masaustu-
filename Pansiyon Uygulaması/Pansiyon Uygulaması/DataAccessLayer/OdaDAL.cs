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
    class OdaDAL : IRepository<Oda>
    {
        private object odalarList;

        public bool Ekle(Oda entity)
        {
            SqlCommand komut = new SqlCommand("insert into Odalar(OdaNo, OdaFiyati, MusaitMi) Values(@odaNo, @odaFiyati, @musaitmi)", Tools.Baglanti);
            komut.Parameters.AddWithValue("odaNo", entity.OdaNo);
            komut.Parameters.AddWithValue("odaFiyati", entity.OdaFiyati);
            komut.Parameters.AddWithValue("musaitmi", entity.MusaitMi);


            return Tools.ExecuteNonQuery(komut);
        }

        public bool Guncelle(Oda entity)
        {
            SqlCommand komut = new SqlCommand("Update Odalar set OdaNo=@odaNo, OdaFiyati=@odaFiyati, MusaitMi=@musaitmi, GuncellemeTarihi=@guncellemetarihi where Id = @id", Tools.Baglanti);
            komut.Parameters.AddWithValue("id", entity.Id);
            komut.Parameters.AddWithValue("odaNo", entity.OdaNo);
            komut.Parameters.AddWithValue("odaFiyati", entity.OdaFiyati);
            komut.Parameters.AddWithValue("musaitmi", entity.MusaitMi);
            komut.Parameters.AddWithValue("guncellemetarihi", entity.GuncellemeTarihi);

            return Tools.ExecuteNonQuery(komut);
        }
        public bool DurumGuncelle(Oda entity)
        {
            SqlCommand komut = new SqlCommand("Update Odalar set  MusaitMi=@musaitMi where Id=@id", Tools.Baglanti);

            komut.Parameters.AddWithValue("@musaitMi", entity.MusaitMi);
            komut.Parameters.AddWithValue("@id", entity.Id);

            return Tools.ExecuteNonQuery(komut);
        }

        public DataTable Listele()
        {


            SqlDataAdapter adapter = new SqlDataAdapter("OdaListele", Tools.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }

        public List<Oda> OdaListele()
        {
            List<Oda> odalarList = new List<Oda>();
            SqlCommand command = new SqlCommand("Select * from Odalar ", Tools.Baglanti);
            try
            {
                if (Tools.Baglanti.State == ConnectionState.Closed)
                {
                    Tools.Baglanti.Open();
                }

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Oda oda = new Oda();
                    oda.Id = Convert.ToInt32(reader["Id"]);
                    oda.OdaNo = reader["OdaNo"].ToString();
                    oda.OdaFiyati = Convert.ToDouble(reader["OdaFiyati"]);
                    oda.MusaitMi = Convert.ToBoolean(reader["MusaitMi"]);

                    odalarList.Add(oda);

                }


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (Tools.Baglanti.State == ConnectionState.Open)
                {
                    Tools.Baglanti.Close();
                }
            }
            return odalarList;

        }

        public bool Sil(int id)
        {
            SqlCommand command = new SqlCommand("Delete from Odalar where Id = @id", Tools.Baglanti);
            command.Parameters.AddWithValue("@id", id);

            return Tools.ExecuteNonQuery(command);
        }

        bool IRepository<Oda>.Guncelle(Oda entity)
        {
            throw new NotImplementedException();
        }
    }
}
