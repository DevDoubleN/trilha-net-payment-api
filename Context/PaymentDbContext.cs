using Microsoft.EntityFrameworkCore;
using tech_test_payment_api.Models.Contatos;
using tech_test_payment_api.Models.Enderecos;
using tech_test_payment_api.Models.Pessoas;
using tech_test_payment_api.Models.Vendas;

namespace tech_test_payment_api.Context
{
    public class PaymentDbContext : DbContext
    {
        public PaymentDbContext(DbContextOptions<PaymentDbContext> options) : base(options)
        {

        }

        public DbSet<Contato> Contato { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<ItensVenda> ItensVendas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
    }
}
