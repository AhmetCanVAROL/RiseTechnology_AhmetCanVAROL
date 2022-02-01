using RiseTechnology.Entities.Abstract;
using RiseTechnology.Entities.General;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseTechnology.Entities.Concrete
{
    public class KISI_ILETISIM_BILGI : BaseEntity
    {
        public BilgiTip IletisimBilgiTip { get; set; }

        [MaxLength(250)]
        public string Icerik { get; set; }
    }
}
