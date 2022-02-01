using Microsoft.EntityFrameworkCore;
using RiseTechnology.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseTechnology.Entities.Context
{
    public class RiseTechContext: DbContext
    {
        public RiseTechContext(DbContextOptions<RiseTechContext> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    string ConnStr = "Server=.; Database = RiseTechnologyDB; Trusted_Connection=True;";
        //    optionsBuilder.UseSqlServer(ConnStr);
        //}


        public DbSet<Kisi> KISILER{ get; set; }
        public DbSet<Kisi_Iletisim_Bilgi> KISI_ILETISIM_BILGILER { get; set; }
        public DbSet<Rapor> RAPORLAR{ get; set; }

    }
}
