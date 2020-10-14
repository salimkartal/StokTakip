using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using MvcStok.Models.Entity;

namespace MvcStok.Controllers
{
    public class GuvenlikController : Controller
    {
        // GET: Guvenlik
        MvcDbStokEntities db = new MvcDbStokEntities();
        public ActionResult GirisYap()
        {
            return View();
        }


        [HttpPost]
        public ActionResult GirisYap(TBLKULLANICI t)
        {
            var bilgiler = db.TBLKULLANICI.FirstOrDefault(x => x.AD == t.AD && x.SIFRE == t.SIFRE);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.AD, false);
                return RedirectToAction("Index", "Musteri");
            }
            else
            {
                return View();
            }
        }
       


    }
}