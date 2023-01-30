using System;

namespace tech_test_payment_api.Models.Enderecos
{
    public class EnderecoFactory
    {
        public Endereco CreateEndereco(int idPessoa, string cep, string caixapostal, string logradouro, string bairro,
            string cidade, string estado, string pais, DateTime dataCadastro)
        {
            Endereco endereco = new Endereco();

            endereco.IdPessoa = idPessoa;
            endereco.Cep = cep.ToUpper();
            endereco.CaixaPostal = caixapostal.ToUpper();
            endereco.Logradouro = logradouro.ToUpper();
            endereco.Bairro = bairro.ToUpper();
            endereco.Cidade = cidade.ToUpper();
            endereco.Estado = estado.ToUpper();
            endereco.Pais = pais.ToUpper();
            endereco.DataCadastro = dataCadastro;

            return endereco;
        }
    }
}
