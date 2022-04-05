using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TA_ASP_Zoknik.Models;

namespace TA_ASP_Zoknik.Controllers
{
    public class ZoknikController : Controller
    {
        private ApplicationDbContext _context;

        public ZoknikController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        // GET: Zoknik
        public ActionResult Index()
        {
            var zoknik = _context.Zoknik.ToList();
            return View(zoknik);
        }

        [Authorize]
        public ActionResult Like(int id)
        {
            var zokniInDb = _context.Zoknik.Single(l => l.Id == id);
            zokniInDb.Like++;
            _context.SaveChanges();

            return RedirectToAction("Index", "Zoknik");
        }

        [Authorize]
        public ActionResult Dislike(int id)
        {
            var zokniInDb = _context.Zoknik.Single(l => l.Id == id);
            zokniInDb.Dislike++;
            _context.SaveChanges();

            return RedirectToAction("Index", "Zoknik");
        }

    }
}