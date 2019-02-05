﻿using CadastroFamilia.Models;
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
            var familia = new Familia() { Id = 1 };
            return View(familia);
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
            var familia = _context.Familias.SingleOrDefault(f => f.Id == id);
            if (familia == null) return HttpNotFound();
            return View(familia);
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