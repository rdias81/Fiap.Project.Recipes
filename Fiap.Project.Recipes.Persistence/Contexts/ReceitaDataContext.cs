using Fiap.Project.Recipes.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Project.Recipes.Persistence.Contexts
{
    public class ReceitaDataContext : DbContext
    {
        public ReceitaDataContext(DbContextOptions<SqlDataContext> options) : base(options)
        {

        }

        public DbSet<Receita> Receitas { get; set; }
    }
}
