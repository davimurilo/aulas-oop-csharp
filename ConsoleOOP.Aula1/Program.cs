// See https://aka.ms/new-console-template for more information


using ConsoleOOP.Aula1;

Console.WriteLine("Hello, World!");


Pessoa pessoa = new Pessoa();


pessoa.Nome = "Pedro";
pessoa.Telefone = "(11) 1222-3333";
pessoa.Email = "pedro@pedro";
pessoa.Nascimento = new DateTime(1980, 1, 20); // DateTime.Parse("20/01/1980");


Console.WriteLine($"{pessoa.Nome} - {pessoa.Telefone} - {pessoa.Email} - {pessoa.Nascimento.Value:dd/MM/yyyy}");

pessoa.Nome = "Murilo";

Console.WriteLine($"{pessoa.Nome} - {pessoa.Telefone} - {pessoa.Email} - {pessoa.Nascimento.Value:dd/MM/yyyy}");

pessoa = new Pessoa();
pessoa.Nome = "Murilo";

Console.WriteLine($"{pessoa.Nome} - {pessoa.Telefone} - {pessoa.Email} - {pessoa.Nascimento:dd/MM/yyyy}");


Pessoa pessoa2 = pessoa;

pessoa2.Nome = "Maria";


Console.WriteLine(pessoa2.Nome);
Console.WriteLine(pessoa.Nome);

int numero = 10;

int numero2 = numero;

numero2 = 20;

Console.WriteLine(numero);
Console.WriteLine(numero2);


List<Pessoa> listaPessoas = new List<Pessoa>();

listaPessoas.Add(new Pessoa { Nome = "José" });
listaPessoas.Add(new Pessoa { Nome = "João" });

foreach(Pessoa pessoas in listaPessoas)
{
    pessoas.Nome = pessoas.Nome?.ToUpper();
}

Console.WriteLine($"{listaPessoas[0].Nome} - {listaPessoas[1].Nome}");


Console.WriteLine(pessoa);

Console.ReadKey();
