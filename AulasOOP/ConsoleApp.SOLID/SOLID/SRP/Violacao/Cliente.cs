using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.SOLID.SOLID.SRP.Violacao
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

        public void SalvarPedido(Pedido pedido)
        {
            pedido.Id = 1;
            pedido.ValorPedido = 100;
            pedido.Cliente = this;

            Console.WriteLine("Salvar Pedido");
        }
    }
}
