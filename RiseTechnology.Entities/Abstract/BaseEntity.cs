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

        [Column(TypeName = "datetime")]
        public DateTime? KayitTarih { get; set; }

        public int? Kaydeden_KullaniciID { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DuzeltmeTarih { get; set; }

        public int? Duzenleyen_KullaniciID { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? SilmeTarih { get; set; }

        public int? Silen_KullaniciID { get; set; }

        public bool Durum { get; set; }
    }
}
