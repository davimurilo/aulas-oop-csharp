namespace ConsoleApp.Aula12_13.Entidades
{
    public class FuncionarioExterno : Funcionario, ISalario, IFuncionarioCadastro
    {
        public string Cargo { get; set ; }

        public decimal AumentarSalario(decimal valor)
        {
            return this.Salario *=  (valor / 100M) + 1;
        }

        public decimal ReduzirSalario(decimal valorReducao)
        {
           return this.Salario *= (valorReducao / 100M) - 1;
        }

        public void Remover(int Id)
        {
            List<Funcionario> funcionarios = new List<Funcionario> { 
            
                new FuncionarioExterno { Id = 1 , Nome = "Davi" },
                new FuncionarioExterno { Id = 2 , Nome = "Ana" },
            };

            Console.WriteLine(funcionarios.Count);

            funcionarios.Remove(funcionarios.FirstOrDefault(n => n.Id == Id));

            Console.WriteLine("Remoção de usuário");

            Console.WriteLine(funcionarios.Count);
        }

        public void Salvar(Funcionario funcionario)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            funcionarios.Add(funcionario);

            Console.WriteLine("Registro Gravado Com Sucesso");
        }


        public void Mensagem() => Console.WriteLine("Bem vindo.");

        public decimal ExibirSalario()
        {
            return this.Salario;
        }
    }
}
