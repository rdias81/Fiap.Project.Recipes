using Fiap.Project.Recipes.Application.Interfaces;
using Fiap.Project.Recipes.Domain.Models;
using Fiap.Project.Recipes.Persistence.Contexts;
using System;
using System.Linq;

namespace Fiap.Project.Recipes.Persistence.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly SqlDataContext _dataContext;

        public UsuarioRepository(SqlDataContext context)
        {
            _dataContext = context ?? throw new ArgumentNullException(nameof(context));
        }
        public Usuario Login(string login, string senha)
        {
            return _dataContext.Usuarios.FirstOrDefault(s => s.Login == login && s.Senha == senha);
        }

        public Usuario Obter(int usuarioId)
        {
            return _dataContext.Usuarios.Find(usuarioId);

        }

        public int SalvarUsuario(Usuario usuario)
        {
            _dataContext.Usuarios.Add(usuario);
            _dataContext.SaveChanges();
            return usuario.Id;
        }
    }
}
