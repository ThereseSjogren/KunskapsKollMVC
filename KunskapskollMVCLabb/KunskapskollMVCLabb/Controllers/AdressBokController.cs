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
            return View(adressBok);
        }
        public ActionResult Create(AdressBok adressbok)
        {
            adressBok.Add(adressbok);
            return PartialView(adressbok);
        }
    }
}