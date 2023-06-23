// See https://aka.ms/new-console-template for more information

using ConsoleApp.Aula14_15.Entidades;

//List<int> listaInteiro = new List<int>();
//List<string> listaString = new List<string>();





//Console.WriteLine("Hello, World!");

//Console.ReadKey();

//List<string> listaTexto = new List<string>();

//Adiciona<string>(listaTexto, "Novo Valor");

//List<int> listaInt = new List<int>();

//Adiciona<int>(listaInt, 10);

//EntrarQualquerCoisa(10);
//EntrarQualquerCoisa("");
//EntrarQualquerCoisa(false);
//EntrarQualquerCoisa(TimeSpan.FromDays);


Anotacoes<string> anotacoesTexto = new ();
//anotacoesTexto.ListaItens = new List<string>();
anotacoesTexto.ListaItens.AddRange(new string[] { "Texto 1" , "Texto 2" , "Texto 3"});


anotacoesTexto.ExibirItens();

Anotacoes<int?> anotacoesInteiros = new();

//anotacoesInteiros.ListaItens = new List<int?>();
anotacoesInteiros.ListaItens.Add(1);
anotacoesInteiros.ListaItens.Add(null);
anotacoesInteiros.ListaItens.Add(3);

anotacoesInteiros.ExibirItens();



AnotacoesVersao2<string> anotacoesVersao2 = new ();

anotacoesVersao2.AdicionarItens("Mais Texto 1");
anotacoesVersao2.AdicionarItens("Mais Texto 2");
anotacoesVersao2.AdicionarItens("Mais Texto 3");


foreach(string item in anotacoesVersao2.ListaItens)
{
    Console.WriteLine(item);
}

anotacoesVersao2.ExibirItens();

AnotacoesVersao2<int> anotacoesVersao2Int = new();

anotacoesVersao2Int.AdicionarItens(100);
anotacoesVersao2Int.AdicionarItens(200);
anotacoesVersao2Int.AdicionarItens(300);

anotacoesVersao2Int.EscreverAnotacao("Teste");
anotacoesVersao2Int.EscreverAnotacao(100);

anotacoesVersao2Int.ExibirItens();


AnotacoesVersao3<int,string> anotacaoIntString = new(1000, "Tipo String");

int codigo = anotacaoIntString.RetornarCodigo();
Console.WriteLine($"Retorno código {codigo}");





TarefaDiaria tarefaDiaria1 = new TarefaDiaria() { Titulo = "Minha manhã", Descricao = "Caminhar" };
TarefaDiaria tarefaDiaria2 = new TarefaDiaria() { Titulo = "Minha tarde", Descricao = "Trabalhar" };
TarefaDiaria tarefaDiaria3 = new TarefaDiaria() { Titulo = "Minha noite", Descricao = "Descansar" };

AnotacoesVersao4<TarefaDiaria> anotacaoTarefaDiaria = new();

anotacaoTarefaDiaria.AdicionarTarefa(tarefaDiaria1);
anotacaoTarefaDiaria.AdicionarTarefa(tarefaDiaria2);
anotacaoTarefaDiaria.AdicionarTarefa(tarefaDiaria3);

Console.WriteLine($"Total tarefa {anotacaoTarefaDiaria.ListaTarefa.Count}");

foreach (TarefaDiaria item in anotacaoTarefaDiaria.ListaTarefa)
{
    Console.WriteLine($"Titulo : {item.Titulo} , Descrição: {item.Descricao}");
}


TarefaDiariaAnalitica tarefaDiariaAnalitica1 = new TarefaDiariaAnalitica() { Titulo = "Minha manhã", Descricao = "Caminhar"  };
TarefaDiariaAnalitica tarefaDiariaAnalitica2 = new TarefaDiariaAnalitica() { Titulo = "Minha tarde", Descricao = "Trabalhar" };
TarefaDiariaAnalitica tarefaDiariaAnalitica3 = new TarefaDiariaAnalitica() { Titulo = "Minha noite", Descricao = "Descansar" };

AnotacoesVersao4<TarefaDiariaAnalitica> anotacaoTarefaDiariaAnalitica = new();

anotacaoTarefaDiariaAnalitica.AdicionarTarefa(tarefaDiariaAnalitica1);
anotacaoTarefaDiariaAnalitica.AdicionarTarefa(tarefaDiariaAnalitica2);
anotacaoTarefaDiariaAnalitica.AdicionarTarefa(tarefaDiariaAnalitica3);

anotacaoTarefaDiariaAnalitica.RemoverTarefa(tarefaDiariaAnalitica3);

Console.WriteLine($"Total tarefa {anotacaoTarefaDiariaAnalitica.ListaTarefa.Count}");

foreach (TarefaDiariaAnalitica item in anotacaoTarefaDiariaAnalitica.ListaTarefa)
{
    Console.WriteLine($"Titulo : {item.Titulo} , Descrição: {item.Descricao}");
}







Console.ReadKey();

//void  EntrarQualquerCoisa<T>(T qualquerCoisa)
//{
//    Console.WriteLine(qualquerCoisa);
//}

//void Adiciona<T>(List<T> lista, T valor)
//{
//    lista.Add(valor);
//}


//void AdicionarTexto(List<string> Lista, string valor)
//{
//  Lista.Add(valor);
//}

//void AdicionarNumero(List<int> Lista, int valor)
//{
//    Lista.Add(valor);
//}

//void AdicionarBooleano(List<bool> Lista, bool valor)
//{
//    Lista.Add(valor);
//}

