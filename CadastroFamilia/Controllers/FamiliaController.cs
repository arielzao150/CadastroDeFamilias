using CadastroFamilia.Models;
using CadastroFamilia.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace CadastroFamilia.Controllers
{
    public class FamiliaController : Controller
    {
        private MyDbContext _context;

        public FamiliaController()
        {
            _context = new MyDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }

        // GET: Familia
        public ActionResult Index()
        {
            return View();
        }

        // GET: Familia/Criar
        public ActionResult Criar()
        {
            var familiaVM = new FormFamiliaViewModel()
            {
                Familia = new Familia()
                {
                    Esposa = new Esposa(),
                    Marido = new Marido(),
                    Filhos = new List<Filho>()
                }
            };
            return View("FormFamilia", familiaVM);
        }

        // POST: Familia/Salva
        [HttpPost]
        public ActionResult Salva(Familia familia)
        {
            if (!ModelState.IsValid)
                return View("FormFamilia");
            if (familia.Id == 0)
                _context.Familias.Add(familia);
            else
            {
                var familiaUpdate = _context.Familias.Single(f => f.Id == familia.Id);
                familiaUpdate.Marido = familia.Marido;
                familiaUpdate.Esposa = familia.Esposa;
                familiaUpdate.Filhos = familia.Filhos;
            }
            _context.SaveChanges();

            return RedirectToAction("List", "Familia");
        }

        // GET: Familia/Search
        public ActionResult Search()
        {
            return View();
        }

        // GET: Familia/List
        public ActionResult List()
        {
            //var familias = GetFamilias();
            var familias = _context.Familias;
            return View(familias);
        }

        // GET: Familia/Details/{id}
        public ActionResult Details(int id)
        {
            var familia = _context.Familias
                .Include("Marido")
                .Include("Esposa")
                .Include("Filhos")
                .SingleOrDefault(f => f.Id == id);
            if (familia == null) return HttpNotFound();

            return View(familia);
        }

        // GET: Familia/Edit/{id}
        public ActionResult Edit(int id)
        {
            var familia = _context.Familias
                .Include("Marido")
                .Include("Esposa")
                .Include("Filhos")
                .SingleOrDefault(f => f.Id == id);
            if (familia == null) return HttpNotFound();

            var familiaVM = new FormFamiliaViewModel
            {
                Familia = familia
            };

            return View("FormFamilia", familiaVM);
        }

        private IEnumerable<Familia> GetFamilias()
        {
            return new List<Familia>
            {
                new Familia
                {
                    Id = 1,
                    Esposa = new Esposa
                    {
                        Id = 1,
                        Email = "esposa@email.com",
                        Nome = "Esposa1"
                    },
                    Marido = new Marido
                    {
                        Id = 1,
                        Nome = "Marido1",
                        Email = "marido@email.com"
                    },
                    Filhos = new List<Filho>
                    {
                        new Filho
                        {
                            Id = 1,
                            Nascimento = DateTime.Now
                        }
                    }
                }
            };
        }
    }
}