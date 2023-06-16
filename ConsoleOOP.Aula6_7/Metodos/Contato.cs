namespace ConsoleOOP.Aula6_7.Metodos
{
    public class Contato
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string Email { get;private set; }

        public Contato(string nome, int idade, string email)
        {
            Nome = nome;
            Idade = idade;
            Email = email;
        }
    }
}
