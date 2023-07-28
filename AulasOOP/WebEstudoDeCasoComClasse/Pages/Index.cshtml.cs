using EstudoDeCasoWebClassesPura.DAO;
using EstudoDeCasoWebClassesPura.Entidades;
using EstudoDeCasoWebClassesPura.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WebEstudoDeCasoComClasse.Pages {
    public class IndexModel : PageModel
    {
        private readonly IClienteDAO _clienteDAO;

        public IndexModel(IClienteDAO clienteDAO) {
            _clienteDAO = clienteDAO;
        }

        [BindProperty]
        public string Nome { get; set; }

        public IEnumerable<Cliente> Cliente { get;set; } = default!;

        public async Task OnGetAsync()
        {

            Cliente = await _clienteDAO.ListarTodos();
            
        }
    }
}
