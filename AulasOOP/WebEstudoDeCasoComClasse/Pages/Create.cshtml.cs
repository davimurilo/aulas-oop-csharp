using EstudoDeCasoWebClassesPura.DAO;
using EstudoDeCasoWebClassesPura.Entidades;
using EstudoDeCasoWebClassesPura.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebEstudoDeCasoComClasse.Pages {
    public class CreateModel : PageModel
    {
        private readonly IClienteDAO _clienteDAO;

        public CreateModel(IClienteDAO clienteDAO) {
            _clienteDAO = clienteDAO;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Cliente Cliente { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || Cliente == null)
            {
                return Page();
            }

            await _clienteDAO.Salvar(Cliente!);

            return RedirectToPage("./Index");
        }
    }
}
