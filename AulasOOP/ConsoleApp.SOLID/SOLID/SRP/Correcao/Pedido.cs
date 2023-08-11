namespace ConsoleApp.SOLID.SOLID.SRP.Correcao
{
    public class Pedido
    {
        public int Id { get; set; }
        public decimal ValorPedido { get; set; }

        public void SalvarPedido(Cliente cliente)
        {
            Id = 1;
            ValorPedido = 100;
            Console.WriteLine($"Salvar Pedido : Cliente {cliente.Nome}");
        }
    }
}
