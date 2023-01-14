using Pansiyon_Uygulaması.EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pansiyon_Uygulaması.EntityLayer.Entities
{
    public class Personel : Base, IKisi
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string KimlikNo { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }


    }
}
