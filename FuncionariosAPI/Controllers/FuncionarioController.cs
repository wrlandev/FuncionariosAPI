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

        [HttpGet("{id}")]
        public async Task<ActionResult> BuscarFuncionarioPorId(int id)
        {
            return Ok(await _funcionario.BuscarFuncionarioPorId(id));
        }

        [HttpPost]
        public async Task<ActionResult> CriarFuncionario(FuncionarioModel funcionario)
        {
            return Ok(await _funcionario.CriarFuncionario(funcionario));
        }

        [HttpPut]
        public async Task<ActionResult> AtualizarFuncionario(FuncionarioModel funcionarioEditado)
        {
            return Ok(await _funcionario.AtualizarFuncionario(funcionarioEditado));
        }

        [HttpPut("Inativa")] 
        public async Task<ActionResult> InativaFuncionario(int id)
        {
            return Ok(await _funcionario.InativaFuncionario(id));
        }

        [HttpDelete]
        public async Task<ActionResult> DeletarFuncionario(int id)
        {
            return Ok(await _funcionario.DeletarFuncionario(id));
        }
    }
}
