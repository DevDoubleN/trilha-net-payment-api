using System;

namespace tech_test_payment_api.Models.Pessoas
{
    public class Vendedor
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public long Matricula { get; set; }
        public double Comissao { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
