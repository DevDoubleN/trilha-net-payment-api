using System;

namespace tech_test_payment_api.ViewModels.Vendas
{
    public class ItensVendaDTO
    {
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public double Acrescimo { get; set; }
        public double Desconto { get; set; }
        public double ValorBruto { get; set; }
        public double ValorLiquido { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
