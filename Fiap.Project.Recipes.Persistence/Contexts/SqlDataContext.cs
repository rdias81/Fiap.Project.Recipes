using Fiap.Project.Recipes.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Project.Recipes.Persistence.Contexts
{
    public class SqlDataContext : DbContext
    {
        public SqlDataContext(DbContextOptions<SqlDataContext> options) : base(options)
        {
        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Categoria>().ToTable("Categorias");
        //    modelBuilder.Entity<Categoria>().Property(c => c.Id).UseIdentityColumn(1, 1);
        //    modelBuilder.Entity<Categoria>().Property(c => c.Titulo).IsRequired();

        //    modelBuilder.Entity<Categoria>()
        //        .HasData(
        //            new Categoria() { Id = 1, Titulo = "Doces e sobremesas", Descricao = "Doces e sobremesas" },
        //            new Categoria() { Id = 2, Titulo = "Bolos e tortas", Descricao = "Bolos e tortas" },
        //            new Categoria() { Id = 3, Titulo = "Massas", Descricao = "Massas" },
        //            new Categoria() { Id = 4, Titulo = "Carnes", Descricao = "Carnes" },
        //            new Categoria() { Id = 5, Titulo = "Aves", Descricao = "Aves" }
        //        );

        //    modelBuilder.Entity<Receita>().ToTable("Receitas");
        //    modelBuilder.Entity<Receita>().Property(r => r.Id).UseIdentityColumn(1, 1);
        //    modelBuilder.Entity<Receita>().Property(r => r.Titulo).IsRequired();
        //    modelBuilder.Entity<Receita>().Property(r => r.Ingredientes).IsRequired();
        //    modelBuilder.Entity<Receita>().Property(r => r.Preparo).IsRequired();
        //    modelBuilder.Entity<Receita>().Property(r => r.CategoriaId).IsRequired();

        //    modelBuilder.Entity<Categoria>()
        //        .HasData(
        //            new Receita()
        //            {
        //                Titulo = "Cookies de aveia",
        //                Descricao = "Deliciosos cookies",
        //                Ingredientes = "ingredientes do cookie",
        //                Preparo = "preparo do cookie",
        //                Tags = "cookie;aveia;",
        //                CategoriaId = 1,
        //                DataInclusao = DateTime.Now
        //            },
        //            new Receita()
        //            {
        //                Titulo = "Pudim de leite",
        //                Descricao = "famoso pudim",
        //                Ingredientes = "ingrdientes do pudim",
        //                Preparo = "preparo do pudim",
        //                Tags = "pudim;leite;",
        //                CategoriaId = 1,
        //                DataInclusao = DateTime.Now
        //            },
        //            new Receita()
        //            {
        //                Titulo = "Bolo de chocolate",
        //                Descricao = "irresistível bolo de chocolate",
        //                Ingredientes = "ingredientes do bolo",
        //                Preparo = "preparo do bolo",
        //                Tags = "bolo;chocolate;",
        //                CategoriaId = 2,
        //                DataInclusao = DateTime.Now
        //            },
        //            new Receita()
        //            {
        //                Titulo = "Torta de limão",
        //                Descricao = "deliciosa torta",
        //                Ingredientes = "ingredientes da torta",
        //                Preparo = "preparo da torta",
        //                Tags = "torta;limao;",
        //                CategoriaId = 2,
        //                DataInclusao = DateTime.Now
        //            },
        //            new Receita()
        //            {
        //                Titulo = "Carbonara",
        //                Descricao = "Massa clássica",
        //                Ingredientes = "ingredientes do carbonara",
        //                Preparo = "preparo do carbonara",
        //                Tags = "carbonara;bacon;",
        //                CategoriaId = 3,
        //                DataInclusao = DateTime.Now
        //            },
        //            new Receita()
        //            {
        //                Titulo = "Lasanha",
        //                Descricao = "almoço de domingo",
        //                Ingredientes = "ingredientes da lasanha",
        //                Preparo = "preparo da lasanha",
        //                Tags = "lasanha;queijo;",
        //                CategoriaId = 3,
        //                DataInclusao = DateTime.Now
        //            },
        //            new Receita()
        //            {
        //                Titulo = "Bolo de carne",
        //                Descricao = "delicioso",
        //                Ingredientes = "ingredientes do bolode carne",
        //                Preparo = "preparo do bolo de carne",
        //                Tags = "carne;queijo;presunto;",
        //                CategoriaId = 4,
        //                DataInclusao = DateTime.Now
        //            },
        //            new Receita()
        //            {
        //                Titulo = "Carne de panela",
        //                Descricao = "tradicional carne de panela",
        //                Ingredientes = "ingredientes de carne de panela",
        //                Preparo = "preparo de carne de panela",
        //                Tags = "",
        //                CategoriaId = 4,
        //                DataInclusao = DateTime.Now
        //            },
        //            new Receita()
        //            {
        //                Titulo = "Strogonoff de frango",
        //                Descricao = "Strogonoff de frango fácil",
        //                Ingredientes = "ingredientes de strogonoff de frango",
        //                Preparo = "preparo de strogonoff de frango",
        //                Tags = "",
        //                CategoriaId = 5,
        //                DataInclusao = DateTime.Now
        //            },
        //            new Receita()
        //            {
        //                Titulo = "Medalhão de frango com bacon",
        //                Descricao = "Medalhão de frango com bacon irresistível",
        //                Ingredientes = "ingredientes de Medalhão de frango com bacon",
        //                Preparo = "preparo de Medalhão de frango com bacon",
        //                Tags = "frango;bacon;",
        //                CategoriaId = 5,
        //                DataInclusao = DateTime.Now
        //            }

        //        );
        //}

    }
}
