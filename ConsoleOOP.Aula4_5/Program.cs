using ClassLibraryExemploClasse.Entidades;
using ConsoleOOP.Aula4_5.Construtor;
using ConsoleOOP.Aula4_5.ModificadoresDeAcesso;

namespace ConsoleOOP.Aula4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var cargo = new Cargo();

            cargo.Descricao = "web design";
            cargo.SetSalario1(2000M);
            cargo.GetSalario1();

            cargo.Salario3 = 3000;

            cargo.SetSalario2(5000);
            

            Console.WriteLine(cargo.Salario3);
            Console.WriteLine(cargo.Salario2);
            Console.WriteLine(cargo.Descricao);


            
            var departamento = new Departamento();

            departamento.Descricao = "Programação";
            

            departamento.EscreverCnae("100.90/100-1");

            departamento.ExibirCnae();


            Console.WriteLine(departamento.Descricao);

            Console.WriteLine("************ Construtores ***************");

            Carro carro = new Carro();
            carro.Marca = "VOLKSWAGEM";
            carro.Modelo = "Fusca";
            carro.Ano = 1976;
            carro.Valor = 100_000M;

            Carro carro2 = new();
            carro2.Marca = "FIAT";
            carro2.Modelo = "Uno";
            carro2.Ano = 2010;
            carro2.Valor = 45_000M;

            var carro3 = new Carro();
            carro3.Marca = "FIAT";
            carro3.Modelo = "Uno";
            carro3.Ano = 2010;
            carro3.Valor = 45_000M;

            Carro carro4 = new Carro() { 
            Marca = "Honda",
            Modelo = "Civic",
            Ano = 2023,
            Valor = 257_000M  };

            Carro carro5 = new ()
            {
                Marca = "Chevrolet",
                Modelo = "Celta",
                Ano = 2011,
                Valor = 21_000M
            };

            Console.WriteLine(carro5.Marca);

            carro5 = null;

            GC.Collect();

            try
            {
                Carro carro6 = new("Fiat", "147", "Branco", 1982, 2000M);
                Console.WriteLine(carro6.Marca);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            

            Contato contato = new Contato("João", "jj@gmail.com");

            Console.WriteLine(contato.Nome);

            contato.AlterarNome("José");

            Console.WriteLine(contato.Nome);


            Contato contato2 = new Contato(DateTime.Now,"João Pedro", "jp@gmail.com");

            Console.WriteLine(contato2.Nome);



            Funcionario funcionario = new Funcionario("Jose", "WEB", 3000M, "Contratar");

            Console.ReadKey();
        }
    }
}