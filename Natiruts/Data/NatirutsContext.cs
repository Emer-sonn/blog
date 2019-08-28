using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Natiruts.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Natiruts.Models
{
    public class NatirutsContext : IdentityDbContext<User>
    {
        public NatirutsContext (DbContextOptions<NatirutsContext> options)
            : base(options)
        {
        }

        public DbSet<Natiruts.Models.Mensagem> Mensagem { get; set; }

        public DbSet<Natiruts.Models.Categoria> Categoria { get; set; }

        public DbSet<Natiruts.Models.Comentario> Comentario { get; set; }
    }
}
