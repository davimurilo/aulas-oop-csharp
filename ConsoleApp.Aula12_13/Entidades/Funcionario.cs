using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Aula12_13.Entidades
{
    public abstract class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public decimal Salario { get; set; }
    }
}
