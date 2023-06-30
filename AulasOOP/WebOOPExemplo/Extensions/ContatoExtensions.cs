using ContatoOOPExemplo;
using System.Runtime.CompilerServices;

namespace WebOOPExemplo.Extensions
{
    public static class ContatoExtensions
    {
        public static string ExibirContatoCompleto(this Contato contato)
        {
            IEnumerable<string> listaParteTexto = new[]
            {
                $"Nome : {contato.Nome}",
                $"Email : {contato.Email}",
                $"Telefone : {contato.Telefone}",
                $"Celular : {contato.Celular}",
                $"WhatsApp : {contato.WhatsApp}",
                $"RedeSocial : {contato.RedeSocial}"
            };

             return $"{string.Join(" | ", listaParteTexto)}";
        }
    }
}
