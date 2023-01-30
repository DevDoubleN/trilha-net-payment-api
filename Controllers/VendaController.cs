using Microsoft.AspNetCore.Mvc;
using System;
using tech_test_payment_api.Context;
using tech_test_payment_api.Models.Vendas;
using tech_test_payment_api.ViewModels.Vendas;

namespace tech_test_payment_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        private readonly PaymentDbContext _context;
        public VendaController(PaymentDbContext context) 
        {
            _context = context;
        }

        /// <summary>
        /// Busca uma venda pelo seu identificador (Id).
        /// </summary>
        /// <param name="id">Identificador da venda</param>
        /// <returns>Retorna os dados da venda referente ao identificador informado.</returns>
        [HttpGet("BuscarVenda/{id}")]
        public IActionResult BuscarVenda(int id)
        {
            var venda = _context.Vendas.Find(id);

            if (venda == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(venda);
            }
        }

        /// <summary>
        /// Registra uma nova venda no banco de dados.
        /// </summary>
        /// <param name="itens">Dados referente aos itens da venda.</param>
        /// <param name="venda">Dados referente ao corpo da venda. Ex.: Empresa, Cliente, Vendedor, etc... </param>
        /// <returns>Retorna status de sucesso ao registrar a venda.</returns>
        [HttpPost("RegistrarVenda")]
        public IActionResult RegistrarVenda(VendaDTO venda)
        {
            if (venda == null)
            {
                return NoContent();
            }
            else
            {
                try
                {
                    ItensVendaFactory itensVendaFactory = new ItensVendaFactory();
                    VendaFactory vendaFactory = new VendaFactory();

                    ItensVenda itensVenda = itensVendaFactory.CreateItensVenda(venda.ItensVenda.VendaId, venda.ItensVenda.ProdutoId, 
                        venda.ItensVenda.Quantidade,venda.ItensVenda.Acrescimo, venda.ItensVenda.Desconto, venda.ItensVenda.ValorBruto,
                        venda.ItensVenda.ValorLiquido, venda.ItensVenda.DataCadastro);

                    Venda novaVenda = vendaFactory.CreateVenda(venda.EmpresaId, venda.ClienteId, venda.VendedorId, venda.AcrescimoTotal,
                        venda.DescontoTotal, venda.ValorTotalBruto, venda.ValorTotalLiquido, StatusVenda.AguardandoPagamento,
                        venda.DataCadastro);

                    _context.ItensVendas.Add(itensVenda);
                    _context.Vendas.Add(novaVenda);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    return NoContent();
                }

                return Ok();
            }           
        }

        [HttpPut("AtualizarVenda")]
        public IActionResult AtualizarVenda(int id, StatusVendaDTO statusVenda)
        {
            var venda = _context.Vendas.Find(id);

            if (venda == null)
            {
                return NotFound();
            }
            else
            {
                if ((venda.Status == StatusVenda.AguardandoPagamento && statusVenda.Status == EnumStatusVendaDTO.PagamentoAprovado) ||
                    (venda.Status == StatusVenda.AguardandoPagamento && statusVenda.Status == EnumStatusVendaDTO.Cancelada) ||
                    (venda.Status == StatusVenda.PagamentoAprovado && statusVenda.Status == EnumStatusVendaDTO.EnviadoParaTransportadora) ||
                    (venda.Status == StatusVenda.PagamentoAprovado && statusVenda.Status == EnumStatusVendaDTO.Cancelada) ||
                    (venda.Status == StatusVenda.EnviadoParaTransportadora && statusVenda.Status == EnumStatusVendaDTO.Entregue))
                {
                    try
                    {
                        venda.Status = (StatusVenda)statusVenda.Status;

                        _context.Vendas.Update(venda);
                        _context.SaveChanges();

                        return Ok();
                    }
                    catch (Exception)
                    {
                        return BadRequest();
                    }
                }

                return BadRequest();
            }            
        }
    }
}
