using System;

namespace tech_test_payment_api.Models.Contatos
{
    public class ContatoFactory
    {
        public Contato CreateContato(int idPessoa, TipoContato tipo, string descricao, DateTime dataCadastro)
        {
            Contato contato = new Contato();

            contato.IdPessoa = idPessoa;
            contato.Tipo = tipo;
            contato.DescricaoContato = descricao.ToUpper();
            contato.DataCadastro = dataCadastro;

            return contato;
        }
    }
}
