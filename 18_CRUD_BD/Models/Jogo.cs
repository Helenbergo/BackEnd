using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _18_CRUD_BD.Models
{
    //DataAnnotation de como será criado nome na tabela no BD (Banco de Dados)
    [Table("Jogos")]
    public class Jogo
    {
        [Key] //DataAnnotation falando para o DB que este atributo será uma cheve
        public int JogoId { get; set; }
        [Required(ErrorMessage="Nome é obrigatório")]
        [Display(Name="Nome do jogo")]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public bool Ativo { get; set; }
    }
}