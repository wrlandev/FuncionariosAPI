using FuncionariosAPI.Models;
using FuncionariosAPI.Service.FuncionarioService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FuncionariosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioInterface _funcionario;
        public FuncionarioController(IFuncionarioInterface funcionario)
        {
            _funcionario = funcionario;
        }

        [HttpGet]
        public async Task<ActionResult> BuscarFuncionarios()
        {
            return Ok(await _funcionario.BuscarFuncionarios());
        }

        [HttpPost]
        public async Task<ActionResult> CriarFuncionario(FuncionarioModel funcionario)
        {
            return Ok(await _funcionario.CriarFuncionario(funcionario));
        }
    }
}
