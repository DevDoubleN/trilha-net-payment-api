using System;
using tech_test_payment_api.ViewModels.Pessoas;

namespace tech_test_payment_api.ViewModels.Enderecos
{
    public class EnderecoDTO
    {
        public int PessoaId { get; set; }
        public virtual PessoaDTO Pessoa { get; set; }
        public string Cep { get; set; }
        public string CaixaPostal { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
