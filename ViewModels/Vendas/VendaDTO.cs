using System;
using tech_test_payment_api.ViewModels.Pessoas;

namespace tech_test_payment_api.ViewModels.Vendas
{
    public class VendaDTO
    {
        public int EmpresaId { get; set; }
        public int ClienteId { get; set; }
        public int VendedorId { get; set; }
        public virtual VendedorDTO Vendedor { get; set; }
        public double AcrescimoTotal { get; set; }
        public double DescontoTotal { get; set; }
        public double ValorTotalBruto { get; set; }
        public double ValorTotalLiquido { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual ItensVendaDTO ItensVenda { get; set; }
    }

    public enum EnumStatusVendaDTO
    {
        AguardandoPagamento,
        PagamentoAprovado,
        EnviadoParaTransportadora,
        Entregue,
        Cancelada
    }
}
