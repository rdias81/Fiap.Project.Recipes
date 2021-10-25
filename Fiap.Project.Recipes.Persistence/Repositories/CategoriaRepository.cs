using Fiap.Project.Recipes.Application.Interfaces;
using Fiap.Project.Recipes.Domain.Models;
using Fiap.Project.Recipes.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Project.Recipes.Persistence.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly CategoriaDataContext _categoriaRepository;

        public CategoriaRepository()
        {
            //_categoriaRepository = new CategoriaDataContext();
        }

        public void Atualizar()
        {
            throw new NotImplementedException();
        }

        public void Excluir()
        {
            throw new NotImplementedException();
        }

        public void Incluir()
        {
            throw new NotImplementedException();
        }

        public Categoria Obter(int id)
        {
            return _categoriaRepository.Categorias.FirstOrDefault(m => m.Id == id);
        }

    }
}
