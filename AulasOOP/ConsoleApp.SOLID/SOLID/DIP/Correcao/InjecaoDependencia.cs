namespace ConsoleApp.SOLID.SOLID.DIP.Correcao {

    public interface IDesconto {
        decimal Descontar(decimal valor);
    }

    public class Pedido {
        public int Id { get; set; }

        public string? Produto { get; set; }

        public decimal Total { get; set; }

        private readonly IDesconto _desconto;
        public Pedido(IDesconto desconto) {
            _desconto = desconto;
        }

        public void RealizarDesconto() {
            Total = _desconto.Descontar(Total);
        }
    }
    public class DescontoPedido : IDesconto {
        public decimal Descontar(decimal valor) {
            return valor - (valor * 0.1M);
        }
    }

    public class DescontoPedido15Porcento : IDesconto {
        public decimal Descontar(decimal valor) {
            return valor - (valor * 0.15M);
        }
    }
}
