using Pansiyon_Uygulaması.EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pansiyon_Uygulaması.EntityLayer.Entities
{
    public class Musteri : Base, IKisi
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string KimlikNo { get; set; }
        public string Cinsiyet { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }


    }
}
