using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
    [Table("CadastroClientes")]
    public class CdastroCliente
    {
        [Key]
        public string NomeCliente { get; set; }
        public string EmailCliente { get; set; }
        public string SenhaCliente { get; set; }
    }
}