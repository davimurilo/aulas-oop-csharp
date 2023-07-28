using EstudoDeCasoWebClassesPura.DAO;
using EstudoDeCasoWebClassesPura.Entidades;
using EstudoDeCasoWebClassesPura.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WebEstudoDeCasoComClasse.Pages {
    public class DeleteModel : PageModel
    {
        private readonly IClienteDAO _clienteDAO;

        public DeleteModel(IClienteDAO clienteDAO) {
            _clienteDAO = clienteDAO;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            await _clienteDAO.Remover(id.GetValueOrDefault());
            
            return RedirectToPage("./Index");
        }
    }
}
