using Fiap.Project.Recipes.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Project.Recipes.Application.Interfaces
{
    public interface IReceitaRepository
    {
        void Incluir(Receita receita);
        void Excluir(int id);
        Receita Obter(int id);
        void Atualizar(Receita receita);
        IEnumerable<Receita> Listar();
    }
}
