using FuncionariosAPI.Data;
using FuncionariosAPI.Models;

namespace FuncionariosAPI.Service.FuncionarioService
{
    public class FuncionarioService : IFuncionarioInterface
    {
        private readonly AppDbContext _context;
        public FuncionarioService(AppDbContext context)
        {
            _context = context;
        }
        public Task<ServiceResponse<List<FuncionarioModel>>> AtualizarFuncionario(FuncionarioModel funcionario)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<FuncionarioModel>> BuscarFuncionarioPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<FuncionarioModel>>> BuscarFuncionarios()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<FuncionarioModel>>> CriarFuncionario(FuncionarioModel funcionario)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<FuncionarioModel>>> DeletarFuncionario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<FuncionarioModel>>> InativaFuncionario(int id)
        {
            throw new NotImplementedException();
        }
    }
}
