


using ConsoleApp.Aula16_17.Extensions;
using ContatoOOPExemplo;

Contato contato = new() { 

Nome = "Davi",
Celular = "(11)1111-11111",
Email = "ddd@gmail.com",
RedeSocial = null,
Telefone = "(11) 1111-1111",
WhatsApp = "(11) 2222 -222"
};

contato.Nome = contato.Nome.Maiusculo();
contato.RedeSocial = contato.RedeSocial?.ToUpper();
contato.WhatsApp = contato.WhatsApp.RemoverEspaco();
contato.ExibirContatoCompletoConsole();

contato.EnviarEmail();
Console.WriteLine(contato.ExibirNomeEmailFormatado(true));

string numero1 = null;
string numero2 = "2000.00";

var numero1Convertido = numero1.ConverterParaDecimal();

if(numero1Convertido > 0)
{
    Console.WriteLine($"Fazer Conta {numero1Convertido}");
    Console.WriteLine(numero1Convertido + numero2.ConverterParaDecimal());
    
}

Console.WriteLine(numero1Convertido + numero2.ConverterParaDecimal());

//Console.WriteLine(numero1 + numero2);

//Console.WriteLine(Convert.ToDecimal(null) + decimal.Parse(null));

Console.ReadKey();



