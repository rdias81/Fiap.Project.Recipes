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
        private readonly SqlDataContext _dataContext;

        public CategoriaRepository(SqlDataContext context)
        {
            _dataContext = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Atualizar(Categoria categoria)
        {
            _dataContext.Entry(categoria).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dataContext.SaveChanges();
        }

        public void Excluir(int id)
        {
            var categoria = _dataContext.Categorias.Find(id);

            if (categoria != null)
            {
                _dataContext.Categorias.Remove(categoria);
                _dataContext.SaveChanges();
            }
        }

        public void Incluir(Categoria categoria)
        {
            _dataContext.Categorias.Add(categoria);
            _dataContext.SaveChanges();
        }

        public Categoria Obter(int id)
        {
            return _dataContext.Categorias.FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Categoria> Listar()
        {
            return _dataContext.Categorias.ToList();
        }
    }
}
