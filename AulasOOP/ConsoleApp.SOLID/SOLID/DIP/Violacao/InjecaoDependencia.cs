namespace ConsoleApp.SOLID.SOLID.DIP.Violacao {

    public class Pedido
    {
        public int Id { get; set; }

        public string? Produto { get; set; }

        public decimal Total { get; set; }

        public void RealizarDesconto(DescontoPedido descontoPedido) {

            Total = descontoPedido.Descontar(Total);
        }

    }
    public class DescontoPedido {
        
        public decimal Descontar(decimal valor) {
            return valor - (valor * 0.1M);
        }
    }
}
