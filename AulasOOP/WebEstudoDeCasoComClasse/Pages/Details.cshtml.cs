using EstudoDeCasoWebClassesPura.DAO;
using EstudoDeCasoWebClassesPura.Entidades;
using EstudoDeCasoWebClassesPura.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WebEstudoDeCasoComClasse.Pages {
    public class DetailsModel : PageModel
    {
        private readonly IClienteDAO _clienteDAO;

        public DetailsModel(IClienteDAO clienteDAO) {
            _clienteDAO = clienteDAO;
        }

        public Cliente Cliente { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _clienteDAO.CarregarPorId(id.GetValueOrDefault());
            if (cliente == null)
            {
                return NotFound();
            }
            else 
            {
                Cliente = cliente;
            }
            return Page();
        }
    }
}
