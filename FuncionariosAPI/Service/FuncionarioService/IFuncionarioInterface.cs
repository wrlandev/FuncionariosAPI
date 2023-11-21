using FuncionariosAPI.Models;

namespace FuncionariosAPI.Service.FuncionarioService
{
    public interface IFuncionarioInterface
    {
        Task<ServiceResponse<List<FuncionarioModel>>> BuscarFuncionarios();
        Task<ServiceResponse<List<FuncionarioModel>>> CriarFuncionario(FuncionarioModel funcionario);
        Task<ServiceResponse<FuncionarioModel>> BuscarFuncionarioPorId(int id);
        Task<ServiceResponse<List<FuncionarioModel>>> AtualizarFuncionario(FuncionarioModel funcionarioEditado);
        Task<ServiceResponse<List<FuncionarioModel>>> DeletarFuncionario(int id);
        Task<ServiceResponse<List<FuncionarioModel>>> InativaFuncionario(int id);
    }
}
