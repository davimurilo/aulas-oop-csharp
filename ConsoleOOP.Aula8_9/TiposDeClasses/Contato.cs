namespace ConsoleOOP.Aula8_9.TiposDeClasses
{
    public class Contato
    {
        public string Nome { get; set; }

        public static int TotalContato { get; set; }

        public Contato(string nome)
        {
            Nome = nome;
            TotalContato++;
        }
        public static void ExibirMensagem() => Console.WriteLine("Classe Contato");
    }
}
