namespace ConsoleApp.SOLID.SOLID.SRP.Correcao
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public bool Validar() => string.IsNullOrEmpty(Nome);

        public void Salvar()
        {
            Console.WriteLine("Salvar Cliente");
        }
    }
}
