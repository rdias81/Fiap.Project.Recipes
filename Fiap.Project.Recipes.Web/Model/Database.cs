﻿using Fiap.Project.Recipes.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Project.Recipes.Web.Model
{
    public class Database : DbContext
    {

        
        protected const string ConnectionString = "";
        public Database()
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Receita> Receitas { get; set; }
        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .ToTable("Categoria");

            modelBuilder.Entity<Categoria>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Categoria>()
                .Property(x => x.Titulo)               
                .IsRequired();

            modelBuilder.Entity<Categoria>()
                .Property(x => x.Descricao)
                .HasMaxLength(50)
                .IsRequired();




            modelBuilder.Entity<Receita>()
             .ToTable("Receita");

            modelBuilder.Entity<Receita>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Receita>()
                .Property(x => x.Titulo)
                .IsRequired();

            modelBuilder.Entity<Receita>()
                .Property(x => x.Descricao)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Receita>()
           .Property(x => x.Titulo)
           .HasMaxLength(50)
           .IsRequired();

            modelBuilder.Entity<Receita>()
           .Property(x => x.Preparo)
           .HasMaxLength(50)
           .IsRequired();

            modelBuilder.Entity<Receita>()
          .Property(x => x.Imagem)          
          .IsRequired();

            modelBuilder.Entity<Receita>()
          .Property(x => x.CategoriaId);
         




        }




    }
}
