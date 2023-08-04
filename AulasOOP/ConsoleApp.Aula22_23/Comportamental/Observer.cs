namespace ConsoleApp.Aula22_23.Comportamental {
    public interface IEstoqueUnidadeObserver {
        void Atualizar(ProdutoBase produtoBase);
    }

    public abstract class ProdutoBase {

        private readonly IList<IEstoqueUnidadeObserver> ListaUnidadeObservadores = new List<IEstoqueUnidadeObserver>();
        public int Quantidade { get; private set; }

        public void VincularUnidade(IEstoqueUnidadeObserver estoqueObserver) => ListaUnidadeObservadores.Add(estoqueObserver);

        public void DesvincularUnidade(IEstoqueUnidadeObserver estoqueObserver) 
            => ListaUnidadeObservadores.Remove(estoqueObserver);

        public void NotificarUnidades() {
            foreach (IEstoqueUnidadeObserver unidade in ListaUnidadeObservadores) {
                unidade.Atualizar(this);
            }
        }

        public void AtualizarQuantidade(int qtde) {
            if (this.Quantidade != qtde) {
                this.Quantidade = qtde;
                this.NotificarUnidades();
            }
        }
    }



    public class EstoqueUnidadeObserver : IEstoqueUnidadeObserver {
        public EstoqueUnidadeObserver(string nomeUnidade) {
            NomeUnidade = nomeUnidade;
        }

        public string NomeUnidade { get; private set; }

        public void Atualizar(ProdutoBase produtoBase) {
            Console.WriteLine($"Unidade {NomeUnidade}, esse produto agora têm {produtoBase.Quantidade} qtde(s).");
        }
    }

    public class Produto : ProdutoBase {
        public string Nome { get; private set; }
        public Produto(string nome, int quantidade) {
            Nome = nome;
            this.AtualizarQuantidade(quantidade);
        }
    }


}
