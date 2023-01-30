using System;
using tech_test_payment_api.Models.Pessoas;

namespace tech_test_payment_api.Models.Enderecos
{
    public class Endereco
    {
        public int Id { get; set; }
        public int IdPessoa { get; set; }
        public virtual Pessoa Pessoa { get; set; }
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
