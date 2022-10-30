using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTravelTripProje.Models.Sınıflar
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string Baslik{ get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public string BlogImage { get; set; }
        //Bloglar tablosu ile yorumlar tablosu arasında bire çok ilşli oluşturmuş olduk...bir blogun birden çok yorumu olabilir fakat bir yorum sadece tek bloga yapılabilir.
       public ICollection<Yorumlar> yorumlars { get; set; }
    }
}