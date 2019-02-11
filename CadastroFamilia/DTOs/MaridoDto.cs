using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadastroFamilia.DTOs
{
    public class MaridoDto
    {
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        public string Nome { get; set; }

        [Required]
        public DateTime Nascimento { get; set; }

        public float Altura { get; set; }
        // FOTO
    }
}