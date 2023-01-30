using System;
using tech_test_payment_api.Models.Contatos;
using tech_test_payment_api.Models.Enderecos;

namespace tech_test_payment_api.Models.Pessoas
{
    public class Empresa
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public DateTime DataInicioContratoSocial { get; set; }
        public long Cnpj { get; set; }
        public long InscricaoEstadual { get; set; }
        public string RamoAtividade { get; set; }
        public int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }
        public int ContatoId { get; set; }
        public virtual Contato Contato { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
