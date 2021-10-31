using Fiap.Project.Recipes.Application.Interfaces;
using Fiap.Project.Recipes.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Project.Recipes.Application.Services
{
    public class ReceitaService : IReceitaService
    {
        private readonly IReceitaRepository _repository;

        public ReceitaService(IReceitaRepository repository)
        {
            _repository = repository;
        }

        public void Atualizar(Receita receita)
        {
            _repository.Atualizar(receita);
        }

        public void Excluir(int id)
        {
            _repository.Excluir(id);
        }

        public void Incluir(Receita receita)
        {
            _repository.Incluir(receita);
        }

        public IEnumerable<Receita> Listar()
        {
            return _repository.Listar();
        }

        public Receita Obter(int id)
        {
            return _repository.Obter(id);
        }
    }
}
