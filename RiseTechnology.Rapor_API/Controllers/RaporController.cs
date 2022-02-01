using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RiseTechnology.DAL.Data;
using RiseTechnology.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPIC.Entities.General;

namespace RiseTechnology.Rapor_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaporController : Controller
    {
        #region Rapor_Islemler
        [HttpPost("IletisimBilgi_Ekle")]
        public IActionResult IletisimBilgi_Ekle([FromBody] RAPOR Nesne)
        {
            Mesajlar<RAPOR> rapor = new Mesajlar<RAPOR>();
            rapor = new Rapor_Islemler().Ekle(Nesne);
            return Json(rapor);
        }

        [HttpPost("IletisimBilgi_Duzenle")]
        public IActionResult IletisimBilgi_Duzenle([FromBody] RAPOR Nesne)
        {
            Mesajlar<RAPOR> rapor = new Mesajlar<RAPOR>();
            rapor = new Rapor_Islemler().Duzelt(Nesne);
            return Json(rapor);
        }

        [HttpGet("IletisimBilgi_Getir")]
        public IActionResult IletisimBilgi_Getir(Guid ObjectID)
        {
            Mesajlar<RAPOR> rapor = new Mesajlar<RAPOR>();
            rapor = new Rapor_Islemler().Getir(x => x.ObjectID == ObjectID);
            return Json(rapor);
        }

        [HttpPost("IletisimBilgi_Sil")]
        public IActionResult IletisimBilgi_Sil(Guid ObjectID)
        {
            Mesajlar<RAPOR> rapor = new Mesajlar<RAPOR>();
            Rapor_Islemler islem = new Rapor_Islemler();
            rapor = islem.Getir(x => x.ObjectID == ObjectID);

            if (rapor.Nesne != null)
                rapor = new Rapor_Islemler().Sil(rapor.Nesne);

            return Json(rapor);
        }
        #endregion
    }
}
