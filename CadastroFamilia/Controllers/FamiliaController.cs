using CadastroFamilia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadastroFamilia.Controllers
{
    public class FamiliaController : Controller
    {
        // GET: Familia
        public ActionResult Index()
        {
            return View();
        }

        // GET: Familia/Criar
        public ActionResult Criar()
        {
            var familia = new Familia() { Id = 1};
            return View(familia);
        }
    }
}