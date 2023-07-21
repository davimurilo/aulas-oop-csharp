namespace ConsoleApp.Aula20_21.Imutabilidades {
    public class Endereco {
        public string Rua { get; }
        public string Numero { get; }
        public string Complemento { get; }
        public string Bairro { get; }
        public string Cidade { get; }
        public string Estado { get; }

        public Endereco(string rua, string numero, string complemento, string bairro, string cidade, string estado) {
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
    }
}
