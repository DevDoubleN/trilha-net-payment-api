using System;

namespace tech_test_payment_api.Models.Pessoas
{
    public class Cliente
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public string CargoCompetencia { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
