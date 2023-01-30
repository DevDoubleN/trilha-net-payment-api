using System;

namespace tech_test_payment_api.ViewModels.Pessoas
{
    public class VendedorDTO
    {
        public int PessoaId { get; set; }
        public long Matricula { get; set; }
        public double Comissao { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
