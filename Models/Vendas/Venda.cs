using System;
using tech_test_payment_api.Models.Pessoas;

namespace tech_test_payment_api.Models.Vendas
{
    public class Venda
    {
        public int Id { get; set; }
        public int EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int VendedorId { get; set; }
        public virtual Vendedor Vendedor { get;set; }
        public double AcrescimoTotal { get; set; }
        public double DescontoTotal { get; set; }
        public double ValorTotalBruto { get; set; }
        public double ValorTotalLiquido { get; set; }
        public StatusVenda Status { get;set; }
        public DateTime DataCadastro { get; set; }
    }

    public enum StatusVenda
    {
        AguardandoPagamento,
        PagamentoAprovado,
        EnviadoParaTransportadora,
        Entregue,
        Cancelada
    }
}
