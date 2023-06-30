using ContatoOOPExemplo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebOOPExemplo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;


        public Contato Contato { get; set; }


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Contato = new()
            {

                Nome = "Davi",
                Celular = "(11)1111-11111",
                Email = "ddd@gmail.com",
                RedeSocial = "facebook",
                Telefone = "(11) 1111-1111",
                WhatsApp = "(11) 2222 -222"
            };

            Contato.ExibirContatoCompletoConsole();
        }
    }
}