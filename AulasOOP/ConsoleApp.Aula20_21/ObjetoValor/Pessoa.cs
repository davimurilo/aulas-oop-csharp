using ConsoleApp.Aula20_21.Excecao;

namespace ConsoleApp.Aula20_21.ObjetoValor {
    public class Pessoa {

        public int Id { get; set; }

        public Documento NroDocumento { get; set; }

        public string Email { get; set; }

    }


    public class Fornecedor {

        public int Codigo { get; init; }

        public Documento CNPJ { get; set; }

        public string EmailRepresentante { get; set; }
    }


    public record Documento {

        public string Valor { get; init; }

        public Documento(string valor) {
            
            ValidarDocumento(valor);
           
            Valor = valor;
        }

        private void ValidarDocumento(string valor) {

            if (valor.Length < 11) throw new DocumentoException("Documento Inválido","Fornecedor");
        }

    }
}
