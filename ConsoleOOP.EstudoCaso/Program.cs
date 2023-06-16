
using ConsoleOOP.EstudoCaso.Entidades;
using ConsoleOOP.EstudoCaso.Servicos;

Console.WriteLine("Seja bem vindo ao programa exibe endereço");
Console.WriteLine("*****************************************");


Console.WriteLine("Escolha a ação abaixo:");
Console.WriteLine("(1) - Buscar Endereço");
Console.WriteLine("(2) - Sair");
Console.WriteLine();

Console.Write("Digite o opção desejada:");
var opcao = int.Parse(Console.ReadLine());


if(opcao == 1)
{
    Console.Write("Digite o CEP:");
    var cep = Console.ReadLine();

    EnderecoServico enderecoServico = new EnderecoServico();

    if (!enderecoServico.CEPValidoParaBusca(cep.Replace("-",""))) {

        Console.WriteLine("CEP Inválido, somente números até 8 digitos");
        Console.ReadKey();
        Environment.Exit(0);
    }

    enderecoServico.BuscarEndereco(cep);

    if (!enderecoServico.ExisteCEP())
    {
        Console.WriteLine("Cep não encontrado");
        Console.ReadKey();
        Environment.Exit(0);
    }
  
        Endereco endereco = enderecoServico.MapearEndereco();

        Console.WriteLine(endereco.ToString());
    
}

if(opcao == 2)
{
    Environment.Exit(0);
}

Console.ReadKey();
