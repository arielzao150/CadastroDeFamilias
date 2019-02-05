using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CadastroFamilia.Models
{
    public class MyDbContext:DbContext
    {
        public DbSet<Esposa> Esposas { get; set; }
        public DbSet<Marido> Maridos { get; set; }
        public DbSet<Filho> Filhos { get; set; }
        public DbSet<Familia> Familias { get; set; }
        public MyDbContext()
        { 
        }
    }
}