using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTravelTripProje.Models.Sınıflar
{
    public class Iletisim
    {
        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public string Mail { get; set; }
        public string Konu { get; set; }
        public string Mesaj{ get; set; }

    }
}