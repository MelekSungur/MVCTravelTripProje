using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;



namespace MVCTravelTripProje.Models.Sınıflar
{
    public class Context:DbContext
    {
        public DbSet<Admin>Admins { get; set; }
        public DbSet <Adress>Adresses { get; set; }
        public DbSet<AnaSayfa>anaSayfas { get; set; }
        public DbSet<Blog>Blogs { get; set; }
        public DbSet<Hakkımızda>hakkımızdas { get; set; }
        public DbSet<Iletisim>Iletisims { get; set; }
        public DbSet<Yorumlar>yorumlars { get; set; }
    }
}