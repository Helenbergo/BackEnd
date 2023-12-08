using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
    [Table("Clientes")]

    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório")]
        [Display(Name = "Nome do usuário")]
        public string Nome { get; set; }
        [Display(Name = "Imagem do usuário")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Senha é obrigatório")]
        [Display(Name = "Senha do usuário")]
        public string Senha { get; set; }
    }
}