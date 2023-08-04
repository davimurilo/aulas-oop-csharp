
using ConsoleApp.Aula18_19.Constantes;
using ConsoleApp.Aula18_19.Entidades;
using ConsoleApp.Aula18_19.Enumeradores;
using ConsoleApp.Aula18_19.Structs;

do
{
    Console.Clear();
    Console.WriteLine("Escolha a opção abaixo:");
    Console.WriteLine("(1) Salvar ");
    Console.WriteLine("(2) Listar ");
    Console.WriteLine("(3) Sair ");
    Console.WriteLine("(4) Excluir ");
    Console.WriteLine("");
    Console.Write("Digite sua opção:");
    var opcao = int.Parse(Console.ReadLine()!);

    if (opcao == OpcaoSistemaConst.SALVAR)
    {
        Cliente cliente = new Cliente("José", ClienteStatusEnum.AGUARDANDO_PROCESSO);
        ClienteDAO clienteDAO = new ClienteDAO();

        var LimiteIdade = Cliente.LIMITE_IDADE;

        Console.WriteLine("Opção Salvar");

        clienteDAO.SalvarCliente(cliente);
    }
    else if (opcao == OpcaoSistemaConst.LISTAR)
    {
        ClienteDAO clienteDAO = new ClienteDAO();

        FiltrosStruct filtros = new FiltrosStruct { nome = "Maria", endereco = "Rua 10" };

        filtros.nome = "Ana";

        FiltrosStruct filtros2 = filtros;

        ClienteDAO clienteDAO2 = clienteDAO;

        Console.WriteLine(ReferenceEquals(clienteDAO2, clienteDAO));

        Console.WriteLine(ReferenceEquals(filtros, filtros2));

        clienteDAO.ObterClientesPorFiltro(filtros);

        Console.WriteLine("Opção Listar");
    }
    else if (opcao == OpcaoSistemaConst.SAIR)
    {
        Console.WriteLine("Opção Sair");
        Console.ReadKey();
        Environment.Exit(0);
    }
    else if (opcao == OpcaoSistemaConst.EXCLUIR)
    {
        Console.WriteLine("Opção Excluir");
    }

    Console.ReadKey();

} while (true);


