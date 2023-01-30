using System;

namespace tech_test_payment_api.Models.Vendas
{
    public class ItensVenda
    {
        public int Id { get; set; }
        public int VendaId { get; set; }
        public virtual Venda Venda { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double Acrescimo { get; set; }
        public double Desconto { get; set; }
        public double ValorBruto { get; set; }
        public double ValorLiquido { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
