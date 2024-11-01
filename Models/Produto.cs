using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetProvei.Models
{
    public class Produto

    {
    [Key]
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal Preco { get; set; }
    public int QuantidadeEstoque { get; set; }
    
    public Guid FornecedorId { get; set; }

    // Relação com Fornecedor
    [ForeignKey("FornecedorId")]
    public Fornecedor Fornecedor { get; set; }
    
    // Relação com VendaProdutos
    public ICollection<VendaProduto> VendaProdutos { get; set; } = new List<VendaProduto>();
    }
}
