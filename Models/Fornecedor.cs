using System.ComponentModel.DataAnnotations;

namespace PetProvei.Models
{
    public class Fornecedor    
{
    [Key]
        public Guid Id { get; set; }
        public string NomeEmpresa { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        // Relação com Produtos
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
