using Fiap.Project.Recipes.Application.Interfaces;
using Fiap.Project.Recipes.Domain.Models;
using System;

namespace Fiap.Project.Recipes.Persistence.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Usuario Login(string login, string senha)
        {
            if (login == "admin" && senha == "123456")
                return new Usuario() { Id = 10, Email = "admin@admin", Login = login, Nome = "Admin", Role = "Administrador" };
            else
                return null;
        }

        public Usuario Obter(int usuarioId)
        {
              return new Usuario() { Id = 10, Email = "admin@admin", Login = "admin", Nome = "Admin", Role = "Administrador" };
           
        }

        public int SalvarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
