namespace ConsoleOOP.Aula8_9.Entidades
{
    public class PessoaBase
    {
        public string Nome { get; set; }

        protected string Segredo { get; set; }

        public void ExibirNome() => Console.WriteLine(this.Nome);
    }


    public class Cliente : PessoaBase
    {
        public DateTime? Cadastro { get; set; }

        public Cliente(string nome)
        {
            this.Nome = nome;
            
        }

        public override string ToString() => $"{this.Nome} - {this.Cadastro!.Value:dd/MM/yyyy}";
        
    }


    public class Colaborador :  PessoaBase
    {
        public decimal Salario { get; set; }

        public Colaborador(string nome) 
        {
            this.Nome = nome;
        }

       
    }

   

}
