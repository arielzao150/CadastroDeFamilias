using CadastroFamilia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadastroFamilia.Controllers
{
    public class MaridoController : Controller
    {
        private MyDbContext _context;

        public MaridoController()
        {
            _context = new MyDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }

        // GET: Marido
        public ActionResult Index()
        {
            return View();
        }

        // GET: Marido/Details/{id}
        public ActionResult Details(int id)
        {
            var marido = _context.Maridos
                .SingleOrDefault(m => m.Id == id);
            if (marido == null) return HttpNotFound();
            return View(marido);
        }
    }
}