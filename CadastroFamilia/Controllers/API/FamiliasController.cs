using AutoMapper;
using CadastroFamilia.DTOs;
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
        public IEnumerable<FamiliaDto> GetFamilias()
        {
            return _context.Familias.ToList().Select(Mapper.Map<Familia, FamiliaDto>);
        }

        // GET /api/familias/1
        public FamiliaDto GetFamilia(int id)
        {
            var familia = _context.Familias.SingleOrDefault(f => f.Id == id);

            if (familia == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return Mapper.Map<Familia, FamiliaDto>(familia);
        }

        // POST /api/familias/1
        [HttpPost]
        public FamiliaDto CreateFamilia(FamiliaDto familiaDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var familia = Mapper.Map<FamiliaDto, Familia>(familiaDto);
            _context.Familias.Add(familia);
            _context.SaveChanges();

            familiaDto.Id = familia.Id;
            return familiaDto;
        }

        // PUT /api/familias/1
        [HttpPut]
        public void UpdateFamilia(int id, FamiliaDto familiaToUpdate)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var familia = _context.Familias.SingleOrDefault(f => f.Id == id);
            if (familia == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(familiaToUpdate, familia);

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
