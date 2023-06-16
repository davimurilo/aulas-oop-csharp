namespace ClassLibraryExemploClasse.Entidades
{
    public class Funcionario
    {

        public string Nome { get; set; }

        public string Cargo { get; set; }

        private decimal Salario { get; set; }

        //Construtor Vazio
        public Funcionario() { }

        //Construtor com parâmetros
        public Funcionario(string nome, string cargo, decimal salario)
        {
            this.Nome = nome;
            this.Cargo = cargo;
            this.Salario = salario;
        }

        public Funcionario(string nome, string cargo, decimal salario, string acao)
            : this(nome, cargo, salario)
        {
            this.ExibirMensagemContratacao(acao);
        }

        public void AumentarSalario(decimal salarioValor)
            => this.Salario += salarioValor;

        public void AumentarSalario(double salarioPercentual)
            => this.Salario *= (decimal)((salarioPercentual / 100d) + 1);

        private decimal AumentarSalarioInterno(decimal salarioPercentual) => this.Salario * ((salarioPercentual / 100) + 1);

        public void DiminuirSalario(decimal salarioValor)
        {

            if(salarioValor >= this.Salario)
            {
                Console.WriteLine("Não foi possível reduzir o salário, pois o valor exede ou iguala o valor atual");
                return;
            }

            this.Salario -= salarioValor;
        }
        public decimal ExibirSalario() => this.Salario;

        //public void DebitarEstoque() => this.Salario = 0; Não Coeso

        private void ExibirMensagemContratacao(string acao)
        {
            if (acao == "Contratar")
            {
                Console.WriteLine($"Contratação Feita Nome: {this.Nome}");

                //Console.WriteLine($"Em 3 meses você terá um aumento de 10% seu salário será: {this.Salario * 1.1M}");

                Console.WriteLine($"Em 3 meses você terá um aumento de 10% seu salário será: {this.AumentarSalarioInterno(salarioPercentual:10M)}");
            }
        }
    }

}
