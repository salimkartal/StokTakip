using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStok.Models.Entity;

namespace MvcStok.Controllers
{
    public class KayitController : Controller
    {
        // GET: Kayit
        MvcDbStokEntities db = new MvcDbStokEntities();
        public ActionResult KayıtOl()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KayıtOl(TBLKULLANICI p1)
        {
            if (!ModelState.IsValid)
            {
                return View("KayıtOl");
            }
            db.TBLKULLANICI.Add(p1);
            db.SaveChanges();
            return View();
        }
    }

    
}