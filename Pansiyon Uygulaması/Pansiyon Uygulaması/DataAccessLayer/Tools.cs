using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pansiyon_Uygulaması.DataAccessLayer
{
    public class Tools
    {
        private static readonly SqlConnection baglanti = new SqlConnection
            (ConfigurationManager.ConnectionStrings["PansiyonUygulamasi"].ConnectionString);

        public static SqlConnection Baglanti
        {
            get
            {
                return baglanti;
            }

        }
        public static bool ExecuteNonQuery(SqlCommand komut)
        {
            bool sonuc = false;
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }


                if (komut.ExecuteNonQuery() > 0)
                {
                    sonuc = true;

                }

            }
            catch (Exception)
            {

            }
            finally
            {


                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
            return sonuc;

        }

        public static bool ExecuteReader(SqlCommand komut)
        {

            bool sonuc = false;
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }


                if (komut.ExecuteReader().HasRows)
                {
                    sonuc = true;

                }

            }
            catch (Exception)
            {

            }
            finally
            {


                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
            return sonuc;

        }


    }
}
