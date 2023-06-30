using ContatoOOPExemplo;

namespace ConsoleApp.Aula16_17.Extensions
{
    public static class ContatoExtensions
    {
        public static void EnviarEmail(this Contato contato)
        {
            Console.WriteLine($"Titulo: Envio de email por {contato.Nome} - ({contato.Email}) ");
        }

        public static string ExibirNomeEmailFormatado(this Contato contato, bool formatoHTML)
        {
            if (formatoHTML)
            {
                return $"<h1>{contato.Nome} - {contato.Email}</h1>";
            }

            return $"{contato.Nome} - {contato.Email}";
        }

    }

}
