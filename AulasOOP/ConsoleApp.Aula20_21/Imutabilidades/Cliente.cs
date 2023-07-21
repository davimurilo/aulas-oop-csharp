using ConsoleApp.Aula20_21.Imutabilidades;

namespace ConsoleApp.Aula20_21.Imutabilidades {
    public class Cliente {
        
        public string Nome { get; private set; }

        public Endereco Endereco1 { get; private set; }

        public EnderecoRecord Endereco2 { get; private set; }

        public Cliente(string nome, Endereco endereco, EnderecoRecord endereco2) {
            Nome = nome;
            Endereco1 = endereco;
            Endereco2 = endereco2;
        }

        public void MudarNome(string nome) => Nome = nome;

        public void MudarEndereco(Endereco endereco) => Endereco1 = endereco;

        public void MudarEndereco2(EnderecoRecord endereco) => Endereco2 = endereco;
    }
}
