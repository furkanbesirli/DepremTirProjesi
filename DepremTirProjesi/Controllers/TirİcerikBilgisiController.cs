using DepremTirProjesi.Models;
using DepremTirProjesi.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DepremTirProjesi.Controllers
{
    public class TirİcerikBilgisiController : Controller
    {
        TirİcerikBilgisiRepository tirİcerikBilgisiRepository;
        Context c;
        public TirİcerikBilgisiController(TirİcerikBilgisiRepository _tirİcerikBilgisiRepository, Context _c)
        {
            tirİcerikBilgisiRepository = _tirİcerikBilgisiRepository;
            c = _c;
        }
        public IActionResult Index()
        {
            return View(tirİcerikBilgisiRepository.TList());
        }
        [HttpGet]
        public IActionResult TirİcerikBilgisiEkle()
        {
            List<SelectListItem> values1 = (from x in c.Sehirs.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.SehirAdi,
                                                Value = x.SehirId.ToString()
                                            }).ToList();

            ViewBag.v1 = values1;

            List<SelectListItem> values2 = (from y in c.Ilces.ToList()
                                            select new SelectListItem
                                            {
                                                Text = y.IlceAdi,
                                                Value = y.IlceId.ToString()
                                            }).ToList();

            ViewBag.v2 = values2;

            List<SelectListItem> values3 = (from z in c.Malzemes.ToList()
                                            select new SelectListItem
                                            {
                                                Text = z.MalzemeAd,
                                                Value = z.MalzemeId.ToString()
                                            }).ToList();

            ViewBag.v3 = values3;
            return View();
        }

        [HttpPost]
        public IActionResult TirİcerikBilgisiEkle(TirİcerikBilgisi t)
        {

            tirİcerikBilgisiRepository.TAdd(t);
            return RedirectToAction("Index");
        }


        public IActionResult TirİcerikBilgisiGet(int id)
        {
            var x = tirİcerikBilgisiRepository.TGet(id);
            List<SelectListItem> values1 = (from a in c.Sehirs.ToList()
                                            select new SelectListItem
                                            {
                                                Text = a.SehirAdi,
                                                Value = a.SehirId.ToString()
                                            }).ToList();

            ViewBag.v1 = values1;

            List<SelectListItem> values2 = (from y in c.Ilces.ToList()
                                            select new SelectListItem
                                            {
                                                Text = y.IlceAdi,
                                                Value = y.IlceId.ToString()
                                            }).ToList();

            ViewBag.v2 = values2;

            List<SelectListItem> values3 = (from z in c.Malzemes.ToList()
                                            select new SelectListItem
                                            {
                                                Text = z.MalzemeAd,
                                                Value = z.MalzemeId.ToString()
                                            }).ToList();

            ViewBag.v3 = values3;
            TirİcerikBilgisi t = new TirİcerikBilgisi
            {
                TirId= x.TirId,
                TirPlaka = x.TirPlaka,
                SehirId = x.SehirId,
                IlceId = x.IlceId,
                MalzemeId = x.MalzemeId
                

            };
            return View("TirİcerikBilgisiGet", t);
        }

        [HttpPost]
        public IActionResult TirİcerikBilgisiGuncelle(TirİcerikBilgisi t)
        {
            var x = tirİcerikBilgisiRepository.TGet(t.TirId);
            x.TirId = t.TirId;
            x.TirPlaka = t.TirPlaka;
            x.SehirId = t.SehirId;
            x.IlceId = t.IlceId;
            x.MalzemeId = t.MalzemeId;
            tirİcerikBilgisiRepository.TUpdate(x);

            return RedirectToAction("Index");
        }

        public IActionResult TirİcerikBilgisiSil(int id)
        {
            tirİcerikBilgisiRepository.TDelete(new TirİcerikBilgisi { TirId = id });
            return RedirectToAction("Index");
        }
    }
}
