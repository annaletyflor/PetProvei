using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetProvei.Models
{
    public class Venda
    {
        [Key]
        public Guid Id { get; set; }

        public Guid ClienteId { get; set; }
        public DateTime DataEmissao { get; set; }
        public decimal ValorTotal { get; set; }

        // Relação com Cliente
        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }

        // Relação com VendaProdutos
        public ICollection<VendaProduto> VendaProdutos { get; set; } = new List<VendaProduto>();
    }
}
