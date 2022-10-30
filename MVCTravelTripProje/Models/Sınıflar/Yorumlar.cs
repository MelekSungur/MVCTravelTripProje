using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTravelTripProje.Models.Sınıflar
{
    public class Yorumlar
    {
        [Key]
        public int ID { get; set; }
        public int KullaniciAdi { get; set; }
        public string Mail{ get; set; }
        public string Yorum { get; set; }
        //Sınıfların içindeki Blog sınıfından gelecek olan değeri tutacak. 
        public Blog Blog { get; set; }
    }
}