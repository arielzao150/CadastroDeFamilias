﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CadastroFamilia.Models
{
    public class Esposa
    {
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Data de Nascimento")]
        public DateTime Nascimento { get; set; }

        public float Altura { get; set; }
    }
}