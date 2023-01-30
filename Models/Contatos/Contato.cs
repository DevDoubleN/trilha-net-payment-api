using System;
using tech_test_payment_api.Models.Pessoas;

namespace tech_test_payment_api.Models.Contatos
{
    public class Contato
    {
        public int Id { get; set; } 
        public int IdPessoa { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public TipoContato Tipo { get; set; }
        public string DescricaoContato { get; set; }
        public DateTime DataCadastro { get; set; }
    }

    public enum TipoContato
    {
        Telefone,
        Email
    }
}
