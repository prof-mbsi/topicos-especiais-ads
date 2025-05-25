using Microsoft.EntityFrameworkCore;

namespace ApiProdutos.Models{
    public class AppDbContext : DbContext{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Cada DbSet representa uma tabela
        public DbSet<Produto> Produtos { get; set; }
    }
}
