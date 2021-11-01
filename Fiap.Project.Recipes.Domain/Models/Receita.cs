using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Project.Recipes.Domain.Models
{
    public class Receita
    {
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        [Required]
        public string Ingredientes { get; set; }
        [Required]
        public string Preparo { get; set; }
        public string Imagem { get; set; }
        public string Tags { get; set; }
        [Required]
        public int CategoriaId { get; set; }
        public Categoria CategoriaReceita { get; set; }
        public DateTime DataInclusao { get; set; }

    }
}
