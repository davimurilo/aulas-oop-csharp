using ConsoleApp.Aula22_23.Comportamental;
using ConsoleApp.Aula22_23.Criacional;
using ConsoleApp.Aula22_23.Estrutural;
using static ConsoleApp.Aula22_23.Comportamental.Strategy;

Console.WriteLine("Design Pattern - Criacional - Singleton");

Console.WriteLine();



for (var i = 0; i <= 10; i++) { 
    var servidorRede = ServidorRedeSingleton.Instance;
    servidorRede.Value.IniciarServidor();
}

var servidorRede1 = ServidorRedeSingleton.Instance;
var servidorRede2 = ServidorRedeSingleton.Instance;
List<int> lista1 = new List<int>();
List<int> lista2 = new List<int>();

Console.WriteLine($"São a mesma instânca ? {ReferenceEquals(servidorRede1, servidorRede2)}");
Console.WriteLine($"São a mesma instânca ? {ReferenceEquals(lista1, lista2)}");


Console.WriteLine();
Console.WriteLine("Design Pattern - Criacional - Method Factory");
Console.WriteLine();

List<ICriadorDispositivo> listaDispositivo = new();

listaDispositivo.Add(new CriadorComputador());
listaDispositivo.Add(new CriadorTV());
listaDispositivo.Add(new CriadorCelular());


foreach (var item in listaDispositivo) {
    IDispositivo dispositivo = item.CriarDispositivo();
    dispositivo.ConfigurarDispositivo();
}

Console.WriteLine();

Console.WriteLine("Design Pattern - Estrutural - Facade");

ProcessoClienteFacade processoClienteFacade = new();
processoClienteFacade.IniciarProcessoCliente(5500.50M);


Console.WriteLine();


Console.WriteLine("Design Pattern - Estrutural - Adapter");
Console.WriteLine();

ImpostoSaoPauloICMS impostoSaoPauloICMS = new ImpostoSaoPauloICMS();
Console.WriteLine($"Imposto Original ICMS : {impostoSaoPauloICMS.CalcularImposto(1000):C}");

ImpostoSaoPauloICMS impostoSaoPauloISSAdapter = new ImpostoISSAdapter();
Console.WriteLine($"Imposto Adaptado Para ISS: {impostoSaoPauloISSAdapter.CalcularImposto(1000):C}");

Console.WriteLine();

Console.WriteLine("Design Pattern - Comportamental - Observer");

Produto produto = new("Morango", 1);
Console.WriteLine($"Produto: {produto.Nome}");

var UnidadeSP = new EstoqueUnidadeObserver($"Unidade SPO");
var UnidadeRJ = new EstoqueUnidadeObserver($"Unidade RJ");
var UnidadeSC = new EstoqueUnidadeObserver($"Unidade SC");

produto.VincularUnidade(UnidadeSP);
produto.VincularUnidade(UnidadeRJ);

produto.AtualizarQuantidade(10);
produto.AtualizarQuantidade(10);
produto.AtualizarQuantidade(15);

produto.DesvincularUnidade(UnidadeSP);
produto.VincularUnidade(UnidadeSC);

produto.AtualizarQuantidade(25);

Console.WriteLine();

Console.WriteLine("Design Pattern - Comportamental - Strategy");
Console.WriteLine();

ContextoMensagem contextoMensagem = new();

contextoMensagem.Configurar(new MensagemEmail())
                .Disparar()
                .Configurar(new MensagemSMS())
                .Disparar()
                .Configurar(new MensagemWhatsApp())
                .Disparar()
                .Configurar(new MensagemWhatsApp())
                .Disparar();


