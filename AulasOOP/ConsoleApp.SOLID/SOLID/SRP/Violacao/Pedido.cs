namespace ConsoleApp.SOLID.SOLID.SRP.Violacao {
    public class Pedido
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public decimal ValorPedido { get; set; }
    }
}
