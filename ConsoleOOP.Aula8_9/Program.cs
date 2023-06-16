
using ConsoleOOP.Aula8_9.Entidades;
using ConsoleOOP.Aula8_9.TiposDeClasses;

PessoaBase pessoaBase = new();
pessoaBase.Nome = "José";



pessoaBase.ExibirNome();


Cliente cliente = new("Ana");
cliente.Cadastro = DateTime.Now;
cliente.ExibirNome();



Colaborador colaborador = new(nome: "Maria");
colaborador.Salario = 2000;


colaborador.ExibirNome();


var textoCliente = cliente.ToString();
var hash = cliente.GetHashCode();
var tipo = cliente.GetType();

Console.WriteLine(textoCliente);
Console.WriteLine(hash);
Console.WriteLine(tipo);


Pedido pedido = new Pedido();

pedido.Nome = "Ana";
pedido.Endereco = "Rua 10 n 20";
pedido.NumeroNF = 123;
pedido.SerieNF = 1;

pedido.ExibirDestinatario();
pedido.EmitirNota();

var totalNome = TratamentoTexto.TotalString(pedido.Nome);

Console.WriteLine(totalNome);
Console.WriteLine(TratamentoTexto.Maiusculo(pedido.Nome));

Contato.ExibirMensagem();

Contato contato = new("Daniel");

Console.WriteLine(contato.Nome);
Console.WriteLine(Contato.TotalContato);

Contato contato2 = new("Zélia");

Console.WriteLine(contato2.Nome);
Console.WriteLine(Contato.TotalContato);

PessoaFisica pessoaFisica = new();
pessoaFisica.Nome = "Maria";
pessoaFisica.Enderecos = new List<Endereco>();

pessoaFisica.Enderecos.Add(new Endereco() { Rua = "Rua 10" });
pessoaFisica.Enderecos.Add(new Endereco() { Rua = "Rua 12" });

Console.WriteLine($"{pessoaFisica.Nome} - {string.Join(",", pessoaFisica.Enderecos.Select(n => n.Rua))}");

try
{
    ValidacaoPessoaFisica validacaoPessoaFisica = new(pessoaFisica);
    Console.WriteLine("Passou no teste");

}catch(Exception ex){
    Console.WriteLine(ex.Message);
}


Console.ReadKey();
