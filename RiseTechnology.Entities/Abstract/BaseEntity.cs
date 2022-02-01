using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseTechnology.Entities.Abstract
{
    public class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ObjectID { get; set; }        

        public DateTime? KayitTarih { get; set; }

        public int? Ka_KullaniciID { get; set; }

        public DateTime? DuzeltmeTarih { get; set; }

        public int? Du_KullaniciID { get; set; }

        public DateTime? SilmeTarih { get; set; }

        public int? Sil_KullaniciID { get; set; }

        public bool Durum { get; set; }
    }
}
