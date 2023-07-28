﻿using EstudoDeCasoWebClassesPura.Entidades;

namespace EstudoDeCasoWebClassesPura.Interfaces {
    public interface IClienteDAO {

        Task Salvar(Cliente cliente);
        Task Alterar(Cliente cliente);
        Task Remover(int id);
        Task<IEnumerable<Cliente>> ListarTodos();
        Task<Cliente> CarregarPorId(int id);
    }
}
