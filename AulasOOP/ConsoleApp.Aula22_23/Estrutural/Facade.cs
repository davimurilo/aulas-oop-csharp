namespace ConsoleApp.Aula22_23.Estrutural {
    public class ProcessoClienteFacade {
        private readonly SMS _mensageria;
        private readonly ClienteDAO _clienteDAO;
        private readonly ClienteFinanceiro _clienteFinanceiro;

        public ProcessoClienteFacade() {
            _mensageria = new SMS();
            _clienteDAO = new ClienteDAO();
            _clienteFinanceiro = new ClienteFinanceiro();
        }

        public void IniciarProcessoCliente(decimal valorReceita) {
            _clienteDAO.Gravar();
            _clienteFinanceiro.RegistrarReceita(valorReceita);
            _mensageria.EnviarMensagem();
        }
    }

    public class SMS {
        public void EnviarMensagem() => Console.WriteLine("Novo Cliente");
    }

    public class ClienteDAO {
        public void Gravar() => Console.WriteLine("Gravar Cliente");
    }

    public class ClienteFinanceiro {
        public void RegistrarReceita(decimal valor) => Console.WriteLine($"Nova Receita {valor:C}");
    }

}
