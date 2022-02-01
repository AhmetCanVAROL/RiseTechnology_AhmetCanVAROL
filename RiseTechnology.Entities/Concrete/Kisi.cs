using RiseTechnology.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseTechnology.Entities.Concrete
{
    public class KISI : BaseEntity
    {
        [MaxLength(70)]
        public string Ad { get; set; }

        [MaxLength(70)]
        public string Soyad { get; set; }

        [MaxLength(70)]
        public string FirmaBilgi { get; set; }
    }
}
