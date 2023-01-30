using System;
using tech_test_payment_api.ViewModels.Contatos;
using tech_test_payment_api.ViewModels.Enderecos;

namespace tech_test_payment_api.ViewModels.Pessoas
{
    public class EmpresaDTO
    {
        public string RazaoSocial { get; set; }
        public DateTime DataInicioContratoSocial { get; set; }
        public long Cnpj { get; set; }
        public long InscricaoEstadual { get; set; }
        public string RamoAtividade { get; set; }
        public int EnderecoId { get; set; }
        public virtual EnderecoDTO Endereco { get; set; }
        public int ContatoId { get; set; }
        public virtual ContatoDTO Contato { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
