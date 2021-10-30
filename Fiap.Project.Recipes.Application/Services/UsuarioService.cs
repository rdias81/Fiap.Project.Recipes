using Fiap.Project.Recipes.Application.Interfaces;
using Fiap.Project.Recipes.Domain.Models;
using System;

namespace Fiap.Project.Recipes.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public Usuario Login(string login, string senha)
        {
            return _usuarioRepository.Login(login, senha);
        }

        public Usuario Obter(int usuarioId)
        {
            return _usuarioRepository.Obter(usuarioId);
        }

        public int SalvarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
