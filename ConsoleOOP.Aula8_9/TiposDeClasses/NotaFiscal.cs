namespace ConsoleOOP.Aula8_9.TiposDeClasses
{
    public partial class Pedido
    {
        public int NumeroNF { get; set; }
        public int SerieNF { get; set; }


        public void EmitirNota() => Console.WriteLine("Nota Emitida");
    }
}
