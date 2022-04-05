using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TA_ASP_Zoknik.Models;

namespace TA_ASP_Zoknik.Controllers
{
    [Authorize]
    public class KolcsonzokController : Controller
    {
        private ApplicationDbContext _context;

        public KolcsonzokController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        // GET: Kolcsonzok
        public ActionResult Index()
        {
            var kolcsonzok = _context.Kolcsonzok.ToList();

            return View(kolcsonzok);
        }

        public ActionResult New()
        {
            var kolcsonzo = new Kolcsonzo { Id = 0 };

            return View(kolcsonzo);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Save(Kolcsonzo kolcsonzo) 
        {
            if (!ModelState.IsValid)
            {
                return View("New", kolcsonzo);
            }

            _context.Kolcsonzok.Add(kolcsonzo);

            _context.SaveChanges();

            return RedirectToAction("Index", "Kolcsonzok");
        }
    }
}