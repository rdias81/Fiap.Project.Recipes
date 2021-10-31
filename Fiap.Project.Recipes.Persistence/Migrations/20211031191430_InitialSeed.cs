using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiap.Project.Recipes.Persistence.Migrations
{
    public partial class InitialSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receitas_Categorias_CategoriaReceitaId",
                table: "Receitas");

            migrationBuilder.DropIndex(
                name: "IX_Receitas_CategoriaReceitaId",
                table: "Receitas");

            migrationBuilder.DropColumn(
                name: "CategoriaReceitaId",
                table: "Receitas");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Receitas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Preparo",
                table: "Receitas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ingredientes",
                table: "Receitas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Receitas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Categorias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "Descricao", "Titulo" },
                values: new object[,]
                {
                    { 1, "Doces e sobremesas", "Doces e sobremesas" },
                    { 2, "Bolos e tortas", "Bolos e tortas" },
                    { 3, "Massas", "Massas" },
                    { 4, "Carnes", "Carnes" },
                    { 5, "Aves", "Aves" }
                });

            migrationBuilder.InsertData(
                table: "Receitas",
                columns: new[] { "Id", "CategoriaId", "DataInclusao", "Descricao", "Imagem", "Ingredientes", "Preparo", "Tags", "Titulo" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 10, 31, 16, 14, 29, 760, DateTimeKind.Local).AddTicks(9823), "Deliciosos cookies", null, "ingredientes do cookie", "preparo do cookie", "cookie;aveia;", "Cookies de aveia" },
                    { 2, 1, new DateTime(2021, 10, 31, 16, 14, 29, 762, DateTimeKind.Local).AddTicks(1563), "famoso pudim", null, "ingrdientes do pudim", "preparo do pudim", "pudim;leite;", "Pudim de leite" },
                    { 3, 2, new DateTime(2021, 10, 31, 16, 14, 29, 762, DateTimeKind.Local).AddTicks(1588), "irresistível bolo de chocolate", null, "ingredientes do bolo", "preparo do bolo", "bolo;chocolate;", "Bolo de chocolate" },
                    { 4, 2, new DateTime(2021, 10, 31, 16, 14, 29, 762, DateTimeKind.Local).AddTicks(1592), "deliciosa torta", null, "ingredientes da torta", "preparo da torta", "torta;limao;", "Torta de limão" },
                    { 5, 3, new DateTime(2021, 10, 31, 16, 14, 29, 762, DateTimeKind.Local).AddTicks(1595), "Massa clássica", null, "ingredientes do carbonara", "preparo do carbonara", "carbonara;bacon;", "Carbonara" },
                    { 6, 3, new DateTime(2021, 10, 31, 16, 14, 29, 762, DateTimeKind.Local).AddTicks(1599), "almoço de domingo", null, "ingredientes da lasanha", "preparo da lasanha", "lasanha;queijo;", "Lasanha" },
                    { 7, 4, new DateTime(2021, 10, 31, 16, 14, 29, 762, DateTimeKind.Local).AddTicks(1602), "delicioso", null, "ingredientes do bolode carne", "preparo do bolo de carne", "carne;queijo;presunto;", "Bolo de carne" },
                    { 8, 4, new DateTime(2021, 10, 31, 16, 14, 29, 762, DateTimeKind.Local).AddTicks(1606), "tradicional carne de panela", null, "ingredientes de carne de panela", "preparo de carne de panela", "", "Carne de panela" },
                    { 9, 5, new DateTime(2021, 10, 31, 16, 14, 29, 762, DateTimeKind.Local).AddTicks(1609), "Strogonoff de frango fácil", null, "ingredientes de strogonoff de frango", "preparo de strogonoff de frango", "", "Strogonoff de frango" },
                    { 10, 5, new DateTime(2021, 10, 31, 16, 14, 29, 762, DateTimeKind.Local).AddTicks(1611), "Medalhão de frango com bacon irresistível", null, "ingredientes de Medalhão de frango com bacon", "preparo de Medalhão de frango com bacon", "frango;bacon;", "Medalhão de frango com bacon" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Receitas_CategoriaId",
                table: "Receitas",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Receitas_Categorias_CategoriaId",
                table: "Receitas",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receitas_Categorias_CategoriaId",
                table: "Receitas");

            migrationBuilder.DropIndex(
                name: "IX_Receitas_CategoriaId",
                table: "Receitas");

            migrationBuilder.DeleteData(
                table: "Receitas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Receitas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Receitas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Receitas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Receitas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Receitas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Receitas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Receitas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Receitas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Receitas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Receitas");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Receitas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Preparo",
                table: "Receitas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Ingredientes",
                table: "Receitas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaReceitaId",
                table: "Receitas",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Categorias",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Receitas_CategoriaReceitaId",
                table: "Receitas",
                column: "CategoriaReceitaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Receitas_Categorias_CategoriaReceitaId",
                table: "Receitas",
                column: "CategoriaReceitaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
