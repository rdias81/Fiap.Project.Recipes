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
    public class ReceitaRepository : IReceitaRepository
    {
        private readonly SqlDataContext _dataContext;

        public ReceitaRepository(SqlDataContext context)
        {
            _dataContext = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Atualizar(Receita receita)
        {
            _dataContext.Entry(receita).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dataContext.SaveChanges();
        }

        public void Excluir(int id)
        {
            var receita = _dataContext.Categorias.Find(id);

            if (receita != null)
            {
                _dataContext.Categorias.Remove(receita);
                _dataContext.SaveChanges();
            }
        }

        public void Incluir(Receita receita)
        {
            _dataContext.Receitas.Add(receita);
            _dataContext.SaveChanges();
        }

        public IEnumerable<Receita> Listar()
        {
            return _dataContext.Receitas.ToList();
        }

        public Receita Obter(int id)
        {
            var receita = _dataContext.Receitas.FirstOrDefault(m => m.Id == id);
            _dataContext.Entry(receita).Reference(r => r.CategoriaReceita).Load();
            return receita;
        }
    }
}
