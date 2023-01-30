using System;

namespace tech_test_payment_api.Models.Vendas
{
    public class ItensVendaFactory
    {
        public ItensVenda CreateItensVenda(int idVenda, int idProduto, int quantidade, double acrescimo, double desconto,
            double valorBruto, double valorLiquido, DateTime dataCadastro)
        {
            ItensVenda itensVenda = new ItensVenda();

            itensVenda.VendaId = idVenda;
            itensVenda.ProdutoId = idProduto;
            itensVenda.Quantidade = quantidade;
            itensVenda.Acrescimo = acrescimo;
            itensVenda.Desconto = desconto;
            itensVenda.ValorBruto = valorBruto;
            itensVenda.ValorLiquido = valorLiquido;
            itensVenda.DataCadastro = dataCadastro;

            return itensVenda;
        }
    }
}
