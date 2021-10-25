using Fiap.Project.Recipes.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Project.Recipes.Persistence.Contexts
{
    public class CategoriaDataContext : DbContext
    {

        public CategoriaDataContext(DbContextOptions<CategoriaDataContext> options) : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }

    }
}
