using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EstudoDeCasoWebClassesPura.DAO;
using EstudoDeCasoWebClassesPura.Entidades;
using EstudoDeCasoWebClassesPura.Interfaces;

namespace WebEstudoDeCasoComClasse.Pages
{
    public class EditModel : PageModel
    {
        private readonly IClienteDAO _clienteDAO;

        public EditModel(IClienteDAO clienteDAO) {
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
            Cliente = cliente;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var cliente = await _clienteDAO.CarregarPorId(Cliente.IdCliente);
            cliente.SexoCliente = Cliente.SexoCliente;
            cliente.NomeCliente = Cliente.NomeCliente;
            cliente.RG_Cliente = Cliente.RG_Cliente;
            cliente.CPF_Cliente = Cliente.CPF_Cliente;
            cliente.DataInclusao = Cliente.DataInclusao;

            try
            {
                await _clienteDAO.Alterar(cliente);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ClienteExists(Cliente.IdCliente))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private async Task<bool> ClienteExists(int id)
        {
            return (await _clienteDAO.CarregarPorId(id)).IdCliente > 0;
        }
    }
}
