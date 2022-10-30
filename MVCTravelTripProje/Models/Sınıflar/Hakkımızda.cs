using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTravelTripProje.Models.Sınıflar
{
    public class Hakkımızda

    {
        [Key]
        public int hakkımızda { get; set; }
        public string FotoUrl { get; set; }
        public string Aciklama { get; set; }
        

    }
}