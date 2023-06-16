using System.Runtime.CompilerServices;

namespace ConsoleOOP.Aula4_5.ModificadoresDeAcesso
{
    public class Cargo
    {
        private string _descricao;

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = SetDescricao(value); }
        }


        protected string? Cnae { get; set; }
        
        private decimal Salario { get; set; }

        public decimal Salario2 { get; private set; }

        public decimal Salario3 { get;  set; }

        private DateTime DataCriacao { get; set; }

        public string? LerCnae() => Cnae;

        public void SetSalario1(decimal salario1)
        {
            Salario = salario1;
        }

        public void GetSalario1()
        {
            Console.WriteLine(this.Salario);
        }


        public void SetSalario2(decimal salario2)
        {
            Salario2 = salario2;
        }


        private string SetDescricao(string? descricao)
        {

            return descricao.ToUpper();
        }


    }


    public class Departamento : Cargo
    {
        

        public void EscreverCnae(string? cnae)
        {
            this.Cnae = cnae;
            
        }
        public void ExibirCnae()
        {
            Console.WriteLine(this.Cnae);
        }

    }

    public class Organizacao : Departamento
    {
        public void ExibirCnae()
        {
            Console.WriteLine(this.Cnae);
        }
    }
}
