namespace ConsoleApp.Aula12_13.Entidades
{
    public interface IMensageria
    {
        void EnviaMensagem();
    }

    public interface IFormatacaoMensagem
    {
        void FormatarMensagem(string mensagem);
    }


    public class EnviaMensagemSimples : IMensageria
    {
        public void EnviaMensagem()
        {
            Console.WriteLine("Envio Mensagem");
        }
    }

    public class EnviaMensagemEmail  : IMensageria, IFormatacaoMensagem
    {
        public string Titulo { get; set; }

        public string Destinatario { get; set; }

        public string Mensagem { get; set; }

        public EnviaMensagemEmail(string titulo, string destinatario, string mensagem)
        {
            Titulo = titulo;
            Destinatario = destinatario;
            Mensagem = mensagem;
        }

        public void EnviaMensagem()
        {
            Console.WriteLine($"Titulo: {this.Titulo}");
            Console.WriteLine($"Destinatario: {this.Destinatario}");
            Console.WriteLine($"Mensagem: {this.Mensagem}");
            Console.WriteLine("Mensagem Envia Por Email");
        }

        public void FormatarMensagem(string mensagem)
        {
            this.Mensagem = $"<strong>{this.Mensagem}</strong>";
        }

        public void MensagemSecreto() => Console.WriteLine("");
    }


    public class Mensageiro
    {

        public void EnviarMensagem(IMensageria enviaMensagemEmail)
        {
            enviaMensagemEmail.EnviaMensagem();
        }
    }
}
