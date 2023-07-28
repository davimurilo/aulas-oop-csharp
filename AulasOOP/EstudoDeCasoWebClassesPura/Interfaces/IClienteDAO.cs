using EstudoDeCasoWebClassesPura.Entidades;
using System.Linq.Expressions;

namespace EstudoDeCasoWebClassesPura.Interfaces {
    public interface IClienteDAO {

        Task Salvar(Cliente cliente);
        Task Alterar(Cliente cliente);
        Task Remover(int id);
        Task<IEnumerable<Cliente>> ListarTodos();
        Task<Cliente> CarregarPorId(int id);

        Task<IEnumerable<Cliente>> CarregarPorFiltro(Expression<Func<Cliente,bool>> filtro);
    }
}
