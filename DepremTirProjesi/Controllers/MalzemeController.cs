using DepremTirProjesi.Models;
using DepremTirProjesi.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DepremTirProjesi.Controllers
{
    public class MalzemeController : Controller
    {
        MalzemeRepository malzemeRepository;
        Context c;

        public MalzemeController(MalzemeRepository _malzemeRepository, Context c)
        {
            malzemeRepository = _malzemeRepository;
            this.c = c;
        }

        public IActionResult Index()
        {
            return View(malzemeRepository.TList());
        }

        [HttpGet]
        public IActionResult MalzemeEkle()
        {
            List<SelectListItem> values = (from x in c.Kategoris.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.KategoriAd,
                                               Value = x.KategoriId.ToString()
                                           }).ToList();

            ViewBag.v1 = values;
            return View();
        }

        [HttpPost]
        public IActionResult MalzemeEkle(Malzeme m)
        {
            
            malzemeRepository.TAdd(m);
            return RedirectToAction("Index");
        }

        public IActionResult MalzemeGet(int id)
        {
            var x = malzemeRepository.TGet(id);

            List<SelectListItem> values = (from y in c.Kategoris.ToList()
                                           select new SelectListItem
                                           {
                                               Text = y.KategoriAd,
                                               Value = y.KategoriId.ToString()
                                           }).ToList();

            ViewBag.v1 = values;
            Malzeme m = new Malzeme
            {
                MalzemeId = x.MalzemeId,
                MalzemeAd = x.MalzemeAd,
                KategoriId = x.KategoriId,
                MalzemeStok = x.MalzemeStok,
               
            };

            return View("MalzemeGet", m);
        }

        [HttpPost]
        public IActionResult MalzemeGuncelle(Malzeme m)
        {
            var x = malzemeRepository.TGet(m.MalzemeId);
            x.MalzemeAd = m.MalzemeAd;
            x.MalzemeStok = m.MalzemeStok;
            x.KategoriId = m.KategoriId;

            malzemeRepository.TUpdate(x);


            return RedirectToAction("Index");
        }

    }
}
