using System.Collections;

namespace ConsoleApp.Aula14_15.Entidades
{
    public class Anotacoes<T>
    {
        public List<T> ListaItens { get; set; } = new List<T>();

        public void ExibirItens()
        {
            foreach (T item in ListaItens)
            {
                Console.WriteLine(item);
            }
        }
    }


    public class AnotacoesVersao2<T>
    {
        private readonly IList<T> _listaItens = new List<T>();
        public IReadOnlyList<T> ListaItens => _listaItens.ToArray();

        public void AdicionarItens(T item)
        {
            this._listaItens.Add(item);
        }

        public void ExibirItens()
        {
            foreach (T item in _listaItens)
            {
                Console.WriteLine(item);
            }
        }

        public void EscreverAnotacao<K>(K informacao)
        {
            Console.WriteLine(informacao);
        }
    }


    public class AnotacoesVersao3<T, K>
    {
        private T Codigo { get; set; }
        public K Tipo { get; private set; }

        public AnotacoesVersao3(T codigo, K tipo)
        {
            Codigo = codigo;
            Tipo = tipo;

            Console.WriteLine($"Codigo : {codigo} - Tipo : {tipo}");
        }

        public T RetornarCodigo() => this.Codigo;
    }


    public interface ITarefa<T> where T : class, new()
    {
        IReadOnlyList<T> ListaTarefa { get; }
        void AdicionarTarefa(T tarefa);

        void RemoverTarefa(T tarefa);
    }

    public class AnotacoesVersao4<Entidade> : ITarefa<Entidade> where Entidade : class, new()
    {
        private readonly IList<Entidade> _listaTarefa = new List<Entidade>();
        public IReadOnlyList<Entidade> ListaTarefa => this._listaTarefa.ToArray();

        public void AdicionarTarefa(Entidade tarefa) => this._listaTarefa.Add(tarefa);

        public void RemoverTarefa(Entidade tarefa) => this._listaTarefa.Remove(tarefa);
        
    }

    public class TarefaDiaria
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
    }

    public class TarefaDiariaAnalitica
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime InicioTarefa { get; set; }
        public DateTime FimDaTarefa { get; set; }
    }

}
