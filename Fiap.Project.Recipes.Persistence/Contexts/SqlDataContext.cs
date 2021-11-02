﻿using Fiap.Project.Recipes.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(new Usuario()
            {
                Id = 1,
                Nome = "Administrador",
                Email = "admin@admin",
                Login = "admin",
                Senha = "123456",
                Role = "Administrador"
            });

            modelBuilder.Entity<Categoria>()
                .HasData(
                    new Categoria() { Id = 1, Titulo = "Doces e sobremesas", Descricao = "Doces e sobremesas" },
                    new Categoria() { Id = 2, Titulo = "Bolos e tortas", Descricao = "Bolos e tortas" },
                    new Categoria() { Id = 3, Titulo = "Massas", Descricao = "Massas" },
                    new Categoria() { Id = 4, Titulo = "Carnes", Descricao = "Carnes" },
                    new Categoria() { Id = 5, Titulo = "Aves", Descricao = "Aves" }
                );

            modelBuilder.Entity<Receita>()
                .HasData(
                    new Receita()
                    {
                        Id = 1,
                        Titulo = "Cookies de aveia",
                        Descricao = "Deliciosos cookies",
                        Ingredientes = "ingredientes do cookie",
                        Preparo = "preparo do cookie",
                        Tags = "cookie;aveia;",
                        CategoriaId = 1,
                        DataInclusao = DateTime.Now
                    },
                    new Receita()
                    {
                        Id= 2,
                        Titulo = "Pudim de leite",
                        Descricao = "famoso pudim",
                        Ingredientes = "ingrdientes do pudim",
                        Preparo = "preparo do pudim",
                        Tags = "pudim;leite;",
                        CategoriaId = 1,
                        DataInclusao = DateTime.Now
                    },
                    new Receita()
                    {
                        Id = 3,
                        Titulo = "Bolo de chocolate",
                        Descricao = "irresistível bolo de chocolate",
                        Ingredientes = "ingredientes do bolo",
                        Preparo = "preparo do bolo",
                        Tags = "bolo;chocolate;",
                        CategoriaId = 2,
                        DataInclusao = DateTime.Now
                    },
                    new Receita()
                    {
                        Id =4,
                        Titulo = "Torta de limão",
                        Descricao = "deliciosa torta",
                        Ingredientes = "ingredientes da torta",
                        Preparo = "preparo da torta",
                        Tags = "torta;limao;",
                        CategoriaId = 2,
                        DataInclusao = DateTime.Now
                    },
                    new Receita()
                    { 
                        Id =5,
                        Titulo = "Carbonara",
                        Descricao = "Massa clássica",
                        Ingredientes = "ingredientes do carbonara",
                        Preparo = "preparo do carbonara",
                        Tags = "carbonara;bacon;",
                        CategoriaId = 3,
                        DataInclusao = DateTime.Now
                    },
                    new Receita()
                    {
                        Id=6,
                        Titulo = "Lasanha",
                        Descricao = "almoço de domingo",
                        Ingredientes = "ingredientes da lasanha",
                        Preparo = "preparo da lasanha",
                        Tags = "lasanha;queijo;",
                        CategoriaId = 3,
                        DataInclusao = DateTime.Now
                    },
                    new Receita()
                    {
                        Id=7,
                        Titulo = "Bolo de carne",
                        Descricao = "delicioso",
                        Ingredientes = "ingredientes do bolode carne",
                        Preparo = "preparo do bolo de carne",
                        Tags = "carne;queijo;presunto;",
                        CategoriaId = 4,
                        DataInclusao = DateTime.Now
                    },
                    new Receita()
                    {
                        Id=8,
                        Titulo = "Carne de panela",
                        Descricao = "tradicional carne de panela",
                        Ingredientes = "ingredientes de carne de panela",
                        Preparo = "preparo de carne de panela",
                        Tags = "",
                        CategoriaId = 4,
                        DataInclusao = DateTime.Now
                    },
                    new Receita()
                    {
                        Id =9,
                        Titulo = "Strogonoff de frango",
                        Descricao = "Strogonoff de frango fácil",
                        Ingredientes = "ingredientes de strogonoff de frango",
                        Preparo = "preparo de strogonoff de frango",
                        Tags = "",
                        CategoriaId = 5,
                        DataInclusao = DateTime.Now
                    },
                    new Receita()
                    {
                        Id=10,
                        Titulo = "Medalhão de frango com bacon",
                        Descricao = "Medalhão de frango com bacon irresistível",
                        Ingredientes = "ingredientes de Medalhão de frango com bacon",
                        Preparo = "preparo de Medalhão de frango com bacon",
                        Tags = "frango;bacon;",
                        CategoriaId = 5,
                        DataInclusao = DateTime.Now
                    }
                );
        }
     
    }
}
