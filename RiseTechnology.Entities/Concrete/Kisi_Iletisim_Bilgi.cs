using RiseTechnology.Entities.Abstract;
using RiseTechnology.Entities.General;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseTechnology.Entities.Concrete
{
    public class KISI_ILETISIM_BILGI : BaseEntity
    {
        [ForeignKey("Kisi")]
        public Guid KisiID { get; set; }
        public KISI Kisi { get; set; }

        public BilgiTip IletisimBilgiTip { get; set; }

        [MaxLength(250)]
        public string Icerik { get; set; }
    }
}
