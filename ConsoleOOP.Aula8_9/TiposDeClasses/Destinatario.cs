namespace ConsoleOOP.Aula8_9.TiposDeClasses
{
    public partial class Pedido
    {
        public string? Nome { get; set; }

        public string? Endereco { get; set; }

        public void ExibirDestinatario() => Console.WriteLine($"{Nome} - {Endereco}");
    }
}
