using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pansiyon_Uygulaması.EntityLayer.Entities
{
    public class Oda : Base
    {
        public string OdaNo { get; set; }
        public double OdaFiyati { get; set; }
        public bool MusaitMi { get; set; }

    }
}
