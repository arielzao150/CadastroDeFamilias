using CadastroFamilia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CadastroFamilia.Controllers.API
{
    public class FamiliasController : ApiController
    {
        private MyDbContext _context;

        public FamiliasController()
        {
            _context = new MyDbContext();
        }

        // GET /api/familias
        public IEnumerable<Familia> GetFamilias()
        {
            return _context.Familias.ToList();
        }

        // GET /api/familias/1
        public Familia GetFamilia(int id)
        {
            var familia = _context.Familias.SingleOrDefault(f => f.Id == id);

            if (familia == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return familia;
        }

        // POST /api/familias/1
        [HttpPost]
        public Familia CreateFamilia(Familia familia)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Familias.Add(familia);
            _context.SaveChanges();

            return familia;
        }

        // PUT /api/familias/1
        [HttpPut]
        public void UpdateFamilia(int id, Familia familiaToUpdate)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var familia = _context.Familias.SingleOrDefault(f => f.Id == id);
            if (familia == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            // TODO

            _context.SaveChanges();
        }

        // DELETE /api/familias/1
        [HttpDelete]
        public void DeleteFamilia(int id)
        {
            var familia = _context.Familias.SingleOrDefault(f => f.Id == id);
            if (familia == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Familias.Remove(familia);
            _context.SaveChanges();
        }
    }
}
