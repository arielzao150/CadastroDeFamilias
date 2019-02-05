using CadastroFamilia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroFamilia.Models
{
    public class Familia
    {
        public int Id { get; set; }
        public Esposa Esposa { get; set; }
        public Marido Marido { get; set; }
        public List<Filho> Filhos { get; set; }
    }
}