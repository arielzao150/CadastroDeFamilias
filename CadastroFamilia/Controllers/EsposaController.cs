using CadastroFamilia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadastroFamilia.Controllers
{
    public class EsposaController : Controller
    {
        private MyDbContext _context;

        public EsposaController()
        {
            _context = new MyDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }

        // GET: Esposa
        public ActionResult Index()
        {
            return View();
        }

        // GET: Esposa/Details/{id}
        public ActionResult Details(int id)
        {
            var esposa = _context.Esposas
                .SingleOrDefault(e => e.Id == id);
            if (esposa == null) return HttpNotFound();
            return View(esposa);
        }
    }
}