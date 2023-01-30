using System;

namespace tech_test_payment_api.Models.Vendas
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Ncm { get; set; }
        public string Cor { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
