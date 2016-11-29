using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KunskapskollMVCLabb.Models;

namespace KunskapskollMVCLabb.Controllers
{
    public class AdressBokController : Controller
    {
        static List<AdressBok> adressBok = new List<AdressBok>();
        public ActionResult Index()
        {
            AdressBok newAdressBok = new AdressBok();
            return View(newAdressBok);
        }
        [HttpPost]
        public ActionResult Create(AdressBok adressbok)
        {
            adressbok.UpdatedDate = DateTime.Now;
            adressBok.Add(adressbok);
            return PartialView("List",adressBok);
        }
        public ActionResult ListaAlla()
        {
            return PartialView("List", adressBok);
        }
        [HttpPost]
        public ActionResult Delete(Guid id)
        {
            var delete = adressBok.First(x => x.AdressBokID == id);
            adressBok.Remove(delete);
            return PartialView("List", adressBok);
        }
        [HttpPost]
        public ActionResult Edit(Guid id)
        {
            var edit = adressBok.Find(x => x.AdressBokID == id);
            adressBok.Add(edit);
            return PartialView("Edit",edit);
        }
    }
}