using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseTechnology.Entities.General
{
    public enum BilgiTip
    {
        [Display(Name = "Telefon Numarası Bilgisi")]
        TelNo = 1,
        [Display(Name = "E-Mail Bilgisi")]
        Email = 2,
        [Display(Name = "Adres Bilgisi")]
        Adres = 3,
        [Display(Name = "Konum Bilgisi")]
        Konum = 4
    }

    public enum RaporDurum
    {
        [Display(Name = "Hazırlanıyor")]
        Hazirlaniyor = 1,
        [Display(Name = "Tamamlandı")]
        Tamamlandi = 2
    }
}
