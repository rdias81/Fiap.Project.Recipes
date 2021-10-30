using Fiap.Project.Recipes.Application.Interfaces;
using Fiap.Project.Recipes.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Project.Recipes.Application.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _repository;

        public CategoriaService(ICategoriaRepository repository)
        {
            _repository = repository;
        }

        public void Atualizar(Categoria categoria)
        {
            _repository.Atualizar(categoria);
        }

        public void Excluir(int id)
        {
            _repository.Excluir(id);
        }

        public void Incluir(Categoria categoria)
        {
            _repository.Incluir(categoria);
        }

        public Categoria Obter(int id)
        {
            return _repository.Obter(id);
        }

        public IEnumerable<Categoria> Listar()
        {
            return _repository.Listar();
        }
    }
}
