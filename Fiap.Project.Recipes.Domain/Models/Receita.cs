using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Project.Recipes.Domain.Models
{
    public class Receita
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Ingredientes { get; set; }
        public string Preparo { get; set; }
        public string Imagem { get; set; }
        public string Tags { get; set; }
        public Categoria CategoriaReceita { get; set; }
        public DateTime DataInclusao { get; set; }

    }
}
