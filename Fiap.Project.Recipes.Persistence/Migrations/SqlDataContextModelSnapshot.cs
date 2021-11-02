﻿// <auto-generated />
using System;
using Fiap.Project.Recipes.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fiap.Project.Recipes.Persistence.Migrations
{
    [DbContext(typeof(SqlDataContext))]
    partial class SqlDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fiap.Project.Recipes.Domain.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Doces e sobremesas",
                            Titulo = "Doces e sobremesas"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Bolos e tortas",
                            Titulo = "Bolos e tortas"
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Massas",
                            Titulo = "Massas"
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "Carnes",
                            Titulo = "Carnes"
                        },
                        new
                        {
                            Id = 5,
                            Descricao = "Aves",
                            Titulo = "Aves"
                        });
                });

            modelBuilder.Entity("Fiap.Project.Recipes.Domain.Models.Receita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataInclusao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredientes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Preparo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Receitas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriaId = 1,
                            DataInclusao = new DateTime(2021, 10, 30, 11, 34, 47, 885, DateTimeKind.Local).AddTicks(4082),
                            Descricao = "Deliciosos cookies",
                            Ingredientes = "ingredientes do cookie",
                            Preparo = "preparo do cookie",
                            Tags = "cookie;aveia;",
                            Titulo = "Cookies de aveia"
                        },
                        new
                        {
                            Id = 2,
                            CategoriaId = 1,
                            DataInclusao = new DateTime(2021, 10, 30, 11, 34, 47, 886, DateTimeKind.Local).AddTicks(7821),
                            Descricao = "famoso pudim",
                            Ingredientes = "ingrdientes do pudim",
                            Preparo = "preparo do pudim",
                            Tags = "pudim;leite;",
                            Titulo = "Pudim de leite"
                        },
                        new
                        {
                            Id = 3,
                            CategoriaId = 2,
                            DataInclusao = new DateTime(2021, 10, 30, 11, 34, 47, 886, DateTimeKind.Local).AddTicks(7843),
                            Descricao = "irresistível bolo de chocolate",
                            Ingredientes = "ingredientes do bolo",
                            Preparo = "preparo do bolo",
                            Tags = "bolo;chocolate;",
                            Titulo = "Bolo de chocolate"
                        },
                        new
                        {
                            Id = 4,
                            CategoriaId = 2,
                            DataInclusao = new DateTime(2021, 10, 30, 11, 34, 47, 886, DateTimeKind.Local).AddTicks(7846),
                            Descricao = "deliciosa torta",
                            Ingredientes = "ingredientes da torta",
                            Preparo = "preparo da torta",
                            Tags = "torta;limao;",
                            Titulo = "Torta de limão"
                        },
                        new
                        {
                            Id = 5,
                            CategoriaId = 3,
                            DataInclusao = new DateTime(2021, 10, 30, 11, 34, 47, 886, DateTimeKind.Local).AddTicks(7849),
                            Descricao = "Massa clássica",
                            Ingredientes = "ingredientes do carbonara",
                            Preparo = "preparo do carbonara",
                            Tags = "carbonara;bacon;",
                            Titulo = "Carbonara"
                        },
                        new
                        {
                            Id = 6,
                            CategoriaId = 3,
                            DataInclusao = new DateTime(2021, 10, 30, 11, 34, 47, 886, DateTimeKind.Local).AddTicks(7852),
                            Descricao = "almoço de domingo",
                            Ingredientes = "ingredientes da lasanha",
                            Preparo = "preparo da lasanha",
                            Tags = "lasanha;queijo;",
                            Titulo = "Lasanha"
                        },
                        new
                        {
                            Id = 7,
                            CategoriaId = 4,
                            DataInclusao = new DateTime(2021, 10, 30, 11, 34, 47, 886, DateTimeKind.Local).AddTicks(7854),
                            Descricao = "delicioso",
                            Ingredientes = "ingredientes do bolode carne",
                            Preparo = "preparo do bolo de carne",
                            Tags = "carne;queijo;presunto;",
                            Titulo = "Bolo de carne"
                        },
                        new
                        {
                            Id = 8,
                            CategoriaId = 4,
                            DataInclusao = new DateTime(2021, 10, 30, 11, 34, 47, 886, DateTimeKind.Local).AddTicks(7857),
                            Descricao = "tradicional carne de panela",
                            Ingredientes = "ingredientes de carne de panela",
                            Preparo = "preparo de carne de panela",
                            Tags = "",
                            Titulo = "Carne de panela"
                        },
                        new
                        {
                            Id = 9,
                            CategoriaId = 5,
                            DataInclusao = new DateTime(2021, 10, 30, 11, 34, 47, 886, DateTimeKind.Local).AddTicks(7925),
                            Descricao = "Strogonoff de frango fácil",
                            Ingredientes = "ingredientes de strogonoff de frango",
                            Preparo = "preparo de strogonoff de frango",
                            Tags = "",
                            Titulo = "Strogonoff de frango"
                        },
                        new
                        {
                            Id = 10,
                            CategoriaId = 5,
                            DataInclusao = new DateTime(2021, 10, 30, 11, 34, 47, 886, DateTimeKind.Local).AddTicks(7929),
                            Descricao = "Medalhão de frango com bacon irresistível",
                            Ingredientes = "ingredientes de Medalhão de frango com bacon",
                            Preparo = "preparo de Medalhão de frango com bacon",
                            Tags = "frango;bacon;",
                            Titulo = "Medalhão de frango com bacon"
                        });
                });

            modelBuilder.Entity("Fiap.Project.Recipes.Domain.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@admin",
                            Login = "admin",
                            Nome = "Administrador",
                            Role = "Administrador",
                            Senha = "123456"
                        });
                });

            modelBuilder.Entity("Fiap.Project.Recipes.Domain.Models.Receita", b =>
                {
                    b.HasOne("Fiap.Project.Recipes.Domain.Models.Categoria", "CategoriaReceita")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoriaReceita");
                });
#pragma warning restore 612, 618
        }
    }
}
