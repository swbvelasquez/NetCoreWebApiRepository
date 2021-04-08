using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiRepository.Models;

namespace WebApiRepository.Data
{
    public class WarDbContext:DbContext
    {
        public WarDbContext(DbContextOptions<WarDbContext> options) : base(options)
        { 
        
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Propuesta> Propuestas { get; set; }
        public DbSet<Voto> Votos { get; set; }
    }
}
