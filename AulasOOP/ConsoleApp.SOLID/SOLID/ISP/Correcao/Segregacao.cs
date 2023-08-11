namespace ConsoleApp.SOLID.SOLID.ISP.Correcao {

    internal interface IClienteCommandDAO {
        void Gravar(Cliente cliente);
        void Alterar(Cliente cliente);
    }

    internal interface IClienteQueryDAO {
        Cliente CarregarPorId(int id);
        IEnumerable<Cliente> ObterTodos();
    }

    internal interface IClienteDAO : IClienteCommandDAO , IClienteQueryDAO {

    }

    internal class ClienteDAO : IClienteDAO {
        public void Alterar(Cliente cliente) {
            throw new NotImplementedException();
        }

        public Cliente CarregarPorId(int id) {
            throw new NotImplementedException();
        }

        public void Gravar(Cliente cliente) {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> ObterTodos() {
            throw new NotImplementedException();
        }
    }

    internal class ClienteGravacaoAlteracaoDAO : IClienteCommandDAO {
        public void Alterar(Cliente cliente) {
            throw new NotImplementedException();
        }

        public void Gravar(Cliente cliente) {
            Console.WriteLine("Gravar");
        }
    }

    internal class RelatorioClienteDAO : IClienteQueryDAO {
        public Cliente CarregarPorId(int id) {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> ObterTodos() {
            throw new NotImplementedException();
        }
    }

    internal class Cliente {
        public int Id { get; set; }
        public string? Nome { get; set; }
    }
}
