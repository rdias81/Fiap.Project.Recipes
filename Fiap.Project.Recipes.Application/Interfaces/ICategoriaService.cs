using Fiap.Project.Recipes.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Project.Recipes.Application.Interfaces
{
    public interface ICategoriaService
    {
        void Incluir(Categoria categoria);
        void Obter(int id);
        void Atualizar(Categoria categoria);
        void Excluir(int id);
    }
}
