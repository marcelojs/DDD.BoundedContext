using System;

namespace Servicos.Eletricos.Cadastro.Application.ViewModels
{
    public class EnderecoViewModel
    {
        //Deve dar a opção de desativar o endereço?
        public Guid EnderecoId { get;  set; }
        public Guid ClienteId { get;  set; }
        public int Numero { get;  set; }
        public string Bairro { get;  set; }
        public string Cidade { get;  set; }
        public string Estado { get;  set; }
        public string Logradouro { get;  set; }
        public string Complemento { get;  set; }
        public DateTime DataCadastro { get;  set; }
        public string CEP { get;  set; }
    }
}