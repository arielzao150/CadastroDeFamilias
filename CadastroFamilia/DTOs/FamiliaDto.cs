using CadastroFamilia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroFamilia.DTOs
{
    public class FamiliaDto
    {
        public int Id { get; set; }
        public EsposaDto Esposa { get; set; }
        public MaridoDto Marido { get; set; }
        public List<FilhoDto> Filhos { get; set; }
    }
}