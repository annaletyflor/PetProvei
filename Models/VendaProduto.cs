using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PetProvei.Models
{
    public class VendaProduto
    {
        [Key]
        public Guid VendaId { get; set; }

        public Guid ProdutoId { get; set; }

        public int Quantidade { get; set; }

        // Relações com Venda e Produto
        [ForeignKey("VendaId")]
        public Venda Venda { get; set; }

        [ForeignKey("ProdutoId")]
        public Produto Produto { get; set; }
    }
}
