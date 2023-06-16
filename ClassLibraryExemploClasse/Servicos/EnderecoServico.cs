using ClassLibraryExemploClasse.Entidades;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace ClassLibraryExemploClasse.Servicos
{
    public class EnderecoServico
    {
        private string RetornoEndereco { get; set; }

        private readonly string URL = "https://viacep.com.br/ws/";

        private bool CEPValido { get; set; } 
        public void BuscarEndereco(string cep)
        {
            var urlBusca = $"{URL}{cep}/json/";
            using var httpClient = new HttpClient();
            using var RetornoURL = httpClient.GetAsync(urlBusca).Result;

            CEPValido = RetornoURL.StatusCode == System.Net.HttpStatusCode.OK;

            RetornoEndereco = RetornoURL.Content.ReadAsStringAsync().Result;
        }

        public Endereco MapearEndereco()
        {
            return JsonConvert.DeserializeObject<Endereco>(RetornoEndereco);
        }

        public bool ExisteCEP()
        {
            return (CEPValido && !this.MapearEndereco().erro);
        }

        public bool CEPValidoParaBusca(string cep) => Regex.IsMatch(cep, @"\d{8}");

    }
}
