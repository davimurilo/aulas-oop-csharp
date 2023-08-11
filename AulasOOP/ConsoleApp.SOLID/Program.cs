



using ConsoleApp.SOLID.SOLID.DIP.Correcao;
using ConsoleApp.SOLID.SOLID.ISP.Correcao;
using ConsoleApp.SOLID.SOLID.LSP.Correcao;
using ConsoleApp.SOLID.SOLID.OCP.Correcao;

NotaFiscal nota = new NotaFiscal();

var total = nota.CalcularImposto(1000M, new ICMS());
Console.WriteLine($"Imposto ICMS :{total} ");

total = nota.CalcularImposto(1000M, new IPI());
Console.WriteLine($"Imposto IPI :{total} ");

total = nota.CalcularImposto(1000M, new ISS());
Console.WriteLine($"Imposto ISS :{total} ");


CalculoBase calCorreto = new CalculoBase();

Calculo calc = new Calculo(calCorreto);


Console.WriteLine(calCorreto.Somar(10, 5));
Console.WriteLine(calc.Somar(10, 5));

IClienteCommandDAO clienteDAO = new ClienteGravacaoAlteracaoDAO();

clienteDAO.Gravar(new Cliente());

Pedido ped = new Pedido(new DescontoPedido());

ped.Total = 1000M;
ped.RealizarDesconto();
Console.WriteLine(ped.Total);


ped = new Pedido(new DescontoPedido15Porcento());

ped.Total = 1000M;
ped.RealizarDesconto();
Console.WriteLine(ped.Total);



Console.ReadKey();