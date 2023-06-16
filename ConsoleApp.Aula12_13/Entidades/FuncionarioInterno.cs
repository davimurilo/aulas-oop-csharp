namespace ConsoleApp.Aula12_13.Entidades
{
    public class FuncionarioInterno : Funcionario, ISalario, IFuncionarioCadastro
    {
        private string _cargo;
        public string Cargo
        {
            get => _cargo.ToUpper();
            set => _cargo = value;
        }

        public decimal AumentarSalario(decimal valorAumento)
        {
            return Salario += valorAumento;
        }

        public decimal ExibirSalario()
        {
            return this.Salario;
        }

        public decimal ReduzirSalario(decimal valorReducao)
        {
            return Salario -= valorReducao;
        }

        public void Remover(int Id)
        {
            Console.WriteLine("Remoção");
        }

        public void Salvar(Funcionario funcionario)
        {
            Console.WriteLine("SAvlar");
        }


    }

       
}
