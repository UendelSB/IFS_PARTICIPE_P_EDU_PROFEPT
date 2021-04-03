using IfsParticipe.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IfsParticipe.Database
{
    public class IfsParticipeContext : DbContext
    {

        public IfsParticipeContext (DbContextOptions<IfsParticipeContext> options) : base(options)
        {

        }

        public DbSet<PDI> PDI { get; set; }

        public DbSet<Demanda> Demanda { get; set; }

        public DbSet<Comentario> Comentario { get; set; }

        public DbSet<Avaliacao> Avaliacao { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

    }
}
