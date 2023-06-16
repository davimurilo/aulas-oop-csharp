using System.Diagnostics;

namespace ConsoleOOP.Aula4_5.Construtor
{
    public class Carro
    {
        public string? Marca { get; set; }

        public string? Modelo {get;set;}
        public string? Cor { get; set; }
        public int Ano { get; set; }
        public decimal Valor { get; set; }

        public Carro() {

            Console.WriteLine("Fui instânciada");
            
        }

        ~Carro()
        {
            Console.WriteLine("Fui destruido, limpado da memória");
        }

        public Carro(string? marca,string? modelo,string? cor, int ano, decimal valor)
        {
            if(ano <= 2010)
            {
                throw new Exception("Não pode criar carros abaixo de 2010");
            }


            this.Marca = marca;
            this.Modelo = modelo;
            this.Cor = cor;
            this.Ano = ano;
            this.Valor = valor;
        }
    }
}
