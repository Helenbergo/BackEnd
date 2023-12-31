using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _19_Atividade_CRUD.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public string Sinopse { get; set; }
        public List<Serie> Series { get; set; }
    }
}