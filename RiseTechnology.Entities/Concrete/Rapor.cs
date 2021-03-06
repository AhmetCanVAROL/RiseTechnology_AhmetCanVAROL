using RiseTechnology.Entities.Abstract;
using RiseTechnology.Entities.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseTechnology.Entities.Concrete
{
    public class RAPOR : BaseEntity
    {
        public string Konum { get; set; }
        public int KayitliKisiSayisi { get; set; }
        public int KayitliTelefonNumarasi { get; set; }
        public DateTime RaporTalepTarih { get; set; }
        public RaporDurum RaporDurumBilgi { get; set; }
    }
}
