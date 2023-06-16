namespace ConsoleOOP.Aula4_5.Construtor
{
    public class Contato
    {
        public string? Nome { get; private set; }
        public string? Email { get; private set; }
        public DateTime Criacao { get; private set; }

        public Contato(string? nome, string? email)
        {
            this.Nome = nome;
            this.Email = email;
        }

        public Contato(string? nome)
        {
            this.Nome = nome;
        }

        public Contato(DateTime criacao,string nome, string email):this(nome,email)
        {
            this.Criacao = criacao;

            Console.WriteLine($"Nome: {this.Nome} - Email: {this.Email} - Data: {this.Criacao:dd/MM/yyyy}");
        }

        public void AlterarNome(string nome) => this.Nome = nome;

        public void AlterarEmail(string email) => this.Email = email;



    }
}
