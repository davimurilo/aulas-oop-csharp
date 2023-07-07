using ConsoleApp.Aula18_19.Enumeradores;
using System.Reflection.Metadata;

namespace ConsoleApp.Aula18_19.Entidades
{
    public class Cliente
    {
        public const string VERSAO = "v1.2";
        public const int LIMITE_IDADE = 18;
        public Cliente(string nome, ClienteStatusEnum idStatus)
        {
            Nome = nome;
            IdStatus = idStatus;
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public byte Idade { get; set; }
        public ClienteStatusEnum IdStatus { get; set; }   

        public void AlterarDados(string versao)
        {
            //VERSAO = versao;
        }

        public void MensagemPorIdade() {

            if (Idade >= LIMITE_IDADE)
            {
                Console.WriteLine("Enviar Mensagem dos Termos para Adulto");
                return;
            }

            if (Idade < LIMITE_IDADE)
            {
                Console.WriteLine("Enviar Mensagem dos Termos para Criança e Adoslecente");
                return;
            }

            

        }
    }

   
}
