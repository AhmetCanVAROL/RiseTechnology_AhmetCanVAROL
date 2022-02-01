using Microsoft.AspNetCore.Mvc;
using RiseTechnology.DAL.Data;
using RiseTechnology.Entities.Concrete;
using System;
using TPIC.Entities.General;

namespace RiseTechnology.Contact_API.Controllers
{
    [ApiController]
    [Route("api/contact/[controller]")]
    public class ContactController : Controller
    {

        #region İletişimBilgi_İşlemleri
        [HttpPost("IletisimBilgi_Ekle")]
        public IActionResult IletisimBilgi_Ekle([FromBody] KISI_ILETISIM_BILGI Nesne)
        {
            Mesajlar<KISI_ILETISIM_BILGI> kisiBilgi = new Mesajlar<KISI_ILETISIM_BILGI>();
            kisiBilgi = new IletisimBilgi_Islemler().Ekle(Nesne);
            return Json(kisiBilgi);
        }

        [HttpPost("IletisimBilgi_Duzenle")]
        public IActionResult IletisimBilgi_Duzenle([FromBody] KISI_ILETISIM_BILGI Nesne)
        {
            Mesajlar<KISI_ILETISIM_BILGI> kisiBilgi = new Mesajlar<KISI_ILETISIM_BILGI>();
            kisiBilgi = new IletisimBilgi_Islemler().Duzelt(Nesne);
            return Json(kisiBilgi);
        }

        [HttpGet("IletisimBilgi_Getir")]
        public IActionResult IletisimBilgi_Getir(Guid ObjectID)
        {
            Mesajlar<KISI_ILETISIM_BILGI> kisiBilgi = new Mesajlar<KISI_ILETISIM_BILGI>();
            kisiBilgi = new IletisimBilgi_Islemler().Getir(x=>x.ObjectID== ObjectID);
            return Json(kisiBilgi);
        }

        [HttpPost("IletisimBilgi_Sil")]
        public IActionResult IletisimBilgi_Sil(Guid ObjectID)
        {
            Mesajlar<KISI_ILETISIM_BILGI> kisiBilgi = new Mesajlar<KISI_ILETISIM_BILGI>();
            IletisimBilgi_Islemler islem = new IletisimBilgi_Islemler();
            kisiBilgi = islem.Getir(x => x.ObjectID == ObjectID);
            
            if (kisiBilgi.Nesne != null)
                kisiBilgi = new IletisimBilgi_Islemler().Sil(kisiBilgi.Nesne);
            
            return Json(kisiBilgi);
        }
        #endregion

        #region Kişi İşlemleri
        [HttpPost("Kisi_Ekle")]
        public IActionResult Kisi_Ekle([FromBody] KISI Nesne)
        {
            Mesajlar<KISI> kisiBilgi = new Mesajlar<KISI>();
            kisiBilgi = new Kisi_Islemler().Ekle(Nesne);
            return Json(kisiBilgi);
        }

        [HttpPost("Kisi_Duzenle")]
        public IActionResult Kisi_Duzenle([FromBody] KISI Nesne)
        {
            Mesajlar<KISI> kisiBilgi = new Mesajlar<KISI>();
            kisiBilgi = new Kisi_Islemler().Duzelt(Nesne);
            return Json(kisiBilgi);
        }

        [HttpGet("Kisi_Getir")]
        public IActionResult Kisi_Getir(Guid ObjectID)
        {
            Mesajlar<KISI> kisiBilgi = new Mesajlar<KISI>();
            kisiBilgi = new Kisi_Islemler().Getir(x => x.ObjectID == ObjectID);
            return Json(kisiBilgi);
        }

        [HttpPost("Kisi_Sil")]
        public IActionResult Kisi_Sil(Guid ObjectID)
        {
            Mesajlar<KISI> kisiBilgi = new Mesajlar<KISI>();
            Kisi_Islemler islem = new Kisi_Islemler();
            kisiBilgi = islem.Getir(x => x.ObjectID == ObjectID);

            if (kisiBilgi.Nesne != null)
                kisiBilgi = new Kisi_Islemler().Sil(kisiBilgi.Nesne);

            return Json(kisiBilgi);
        }
        #endregion

    }
}
