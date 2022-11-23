using Microsoft.EntityFrameworkCore;

namespace ControleEstoque.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) :
                                                   base(options)
        { }
        public DbSet<Estoque> estoque { get; set; }
        public DbSet<CompraProduto> compras { get; set; }
        public DbSet<Fornecedor> fornecedores { get; set; }
        public DbSet<Produto> produtos { get; set; }

    }
}

