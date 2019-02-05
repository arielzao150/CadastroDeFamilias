using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CadastroFamilia.Models
{
    public class Filho
    {
        public int Id { get; set; }
        //public int FamiliaId { get; set; }
        //public Familia Familia { get; set; }
        [Required]
        [Display(Name = "Data de Nascimento")]
        public DateTime Nascimento { get; set; }
    }
}