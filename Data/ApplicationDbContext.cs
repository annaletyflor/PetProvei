using Microsoft.EntityFrameworkCore;
using PetProvei.Models;

namespace PetProvei.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<PetProvei.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<PetProvei.Models.Fornecedor> Fornecedor { get; set; } = default!;
        public DbSet<PetProvei.Models.Produto> Produto { get; set; } = default!;
        public DbSet<PetProvei.Models.Venda> Venda { get; set; } = default!;
        public DbSet<PetProvei.Models.VendaProduto> VendaProduto { get; set; } = default!;
    }
}
