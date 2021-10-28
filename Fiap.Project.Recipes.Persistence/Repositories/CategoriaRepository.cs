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
        private readonly SqlDataContext _categoriaContext;

        public CategoriaRepository(SqlDataContext context)
        {
            _categoriaContext = context ?? throw new ArgumentNullException(nameof(context));
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
            return _categoriaContext.Categorias.FirstOrDefault(m => m.Id == id);
        }

    }
}
