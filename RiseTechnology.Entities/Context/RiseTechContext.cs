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

        public DbSet<KISI> KISILER{ get; set; }
        public DbSet<KISI_ILETISIM_BILGI> KISI_ILETISIM_BILGILER { get; set; }
        public DbSet<RAPOR> RAPORLAR{ get; set; }

    }
}
