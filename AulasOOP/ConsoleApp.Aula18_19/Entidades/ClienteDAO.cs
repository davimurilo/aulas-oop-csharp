using ConsoleApp.Aula18_19.Structs;

namespace ConsoleApp.Aula18_19.Entidades
{
 
    public class ClienteDAO
    {
        public void SalvarCliente(Cliente cliente)
        {
            Console.WriteLine("Salvar No Banco");
        }

        public List<Cliente> ObterClientesPorFiltro(FiltrosStruct filtrosStruct)
        {
            var lista = new List<Cliente>();

            if(!string.IsNullOrEmpty(filtrosStruct.nome))
            {
               lista = lista.Where(n => n.Equals(filtrosStruct.nome)).ToList();
            }

            if (filtrosStruct.idade > 0)
            {
                lista = lista.Where(n => n.Idade == filtrosStruct.idade).ToList();
            }

            //

            return lista;
        }
    }
}
