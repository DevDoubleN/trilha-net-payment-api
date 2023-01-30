using System;
using tech_test_payment_api.ViewModels.Contatos;
using tech_test_payment_api.ViewModels.Enderecos;

namespace tech_test_payment_api.ViewModels.Pessoas
{
    public class PessoaDTO
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public long Cpf { get; set; }
        public string OrgaoExpedidor { get; set; }
        public string Escolaridade { get; set; }
        public int EnderecoId { get; set; }
        public int ContatoId { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
