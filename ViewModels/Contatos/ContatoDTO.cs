using System;
using tech_test_payment_api.ViewModels.Pessoas;

namespace tech_test_payment_api.ViewModels.Contatos
{
    public class ContatoDTO
    {
        public int PessoaId { get; set; }
        public virtual PessoaDTO Pessoa { get; set; }
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
