using System;
using tech_test_payment_api.Models.Contatos;
using tech_test_payment_api.Models.Enderecos;

namespace tech_test_payment_api.Models.Pessoas
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public long Cpf { get; set; }
        public string OrgaoExpedidor { get; set; }
        public string Escolaridade { get; set; }
        public int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }
        public int ContatoId { get; set; }
        public virtual Contato Contato { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
