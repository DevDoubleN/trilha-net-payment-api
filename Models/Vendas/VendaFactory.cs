using System;

namespace tech_test_payment_api.Models.Vendas
{
    public class VendaFactory
    {
        public Venda CreateVenda(int empresaId, int clienteId, int vendedorId, double acrescimoTotal, double descontoTotal,
            double valorTotalBruto, double valorTotalLiquido, StatusVenda status, DateTime dataCadastro)
        {
            Venda venda = new Venda();

            venda.EmpresaId = empresaId;
            venda.ClienteId = clienteId;
            venda.VendedorId = vendedorId;
            venda.AcrescimoTotal = acrescimoTotal;
            venda.DescontoTotal= descontoTotal;
            venda.ValorTotalBruto = valorTotalBruto;
            venda.ValorTotalLiquido = valorTotalLiquido;
            venda.Status = status;
            venda.DataCadastro = dataCadastro;

            return venda;
        }
    }
}
