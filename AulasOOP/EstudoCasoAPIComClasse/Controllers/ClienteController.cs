using EstudoDeCasoWebClassesPura.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EstudoCasoAPIComClasse.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase {

        private readonly IClienteDAO _clienteDAO;
        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger, IClienteDAO clienteDAO) {
            _logger = logger;
            _clienteDAO = clienteDAO;
        }

        [HttpGet]
        public async Task<IActionResult> Get() {

            return Ok(await _clienteDAO.ListarTodos());
        }
    }
}