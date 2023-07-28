using EstudoDeCasoWebClassesPura.DAO;
using EstudoDeCasoWebClassesPura.Entidades;
using EstudoDeCasoWebClassesPura.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EstudoDeCasoWebClassesPura.Servicos {
    public class ClienteDAO : IClienteDAO {

        private readonly ContextoGeral contextoGeral;

        public ClienteDAO(ContextoGeral contextoGeral) {
            this.contextoGeral = contextoGeral;
        }

        public async Task Alterar(Cliente cliente) {

            contextoGeral.Cliente.Update(cliente);
            await contextoGeral.SaveChangesAsync();
        }

        public async Task<Cliente> CarregarPorId(int id) {
            return await contextoGeral.Cliente.FirstOrDefaultAsync(n => n.IdCliente == id) ?? new();
        }

        public async Task<IEnumerable<Cliente>> ListarTodos() {
            return await contextoGeral.Cliente.ToListAsync();
        }

        public async Task Remover(int id) {
            var cliente = await this.CarregarPorId(id);
            contextoGeral.Remove(cliente);
            await contextoGeral.SaveChangesAsync();
        }

        public async Task Salvar(Cliente cliente) {
            await contextoGeral.Cliente.AddAsync(cliente);
            await contextoGeral.SaveChangesAsync();
        }
    }
}
