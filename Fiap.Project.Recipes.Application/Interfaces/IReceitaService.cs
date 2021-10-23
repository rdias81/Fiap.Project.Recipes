using Fiap.Project.Recipes.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Project.Recipes.Application.Interfaces
{
    public interface IReceitaService
    {
        IEnumerable<Receita> ListarMaisRecentes();
        void Incluir(Receita receita);
        void Obter(int id);
        void Atualizar(Receita receita);
        void Excluir(int id);
    }
}
