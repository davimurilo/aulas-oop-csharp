namespace ConsoleApp.SOLID.SOLID.ISP.Violacao {

    internal interface IClienteDAO {
        void Gravar(Cliente cliente);
        void Alterar(Cliente cliente);
        Cliente CarregarPorId(int id);
        IEnumerable<Cliente> ObterTodos();

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

    internal class ClienteGravacaoAlteracaoDAO : IClienteDAO {
        public void Alterar(Cliente cliente) {
            Console.WriteLine("Alterar");
        }

        public Cliente CarregarPorId(int id) {
            throw new NotImplementedException();
        }

        public void Gravar(Cliente cliente) {
            Console.WriteLine("Gravar");
        }

        public IEnumerable<Cliente> ObterTodos() {
            throw new NotImplementedException();
        }
    }

    internal class RelatorioClienteDAO : IClienteDAO {
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

    internal class Cliente {
        public int Id { get; set; }
        public string? Nome { get; set; }
    }
}
