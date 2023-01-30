using System;

namespace tech_test_payment_api.ViewModels.Pessoas
{
    public class ClienteDTO
    {
        public string RazaoSocial { get; set; }
        public int PessoaId { get; set; }
        public virtual PessoaDTO Pessoa { get; set; }
        public string CargoCompetencia { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
