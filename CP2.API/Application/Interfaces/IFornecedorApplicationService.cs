using CP2.API.Application.Dtos;
using CP2.API.Domain.Entities;
using System.Collections.Generic;

namespace CP2.API.Application.Interfaces
{
    public interface IFornecedorApplicationService
    {
        FornecedorEntity? ObterFornecedorPorId(int id);
        IEnumerable<FornecedorEntity> ObterTodosFornecedores();
        FornecedorEntity SalvarDadosFornecedor(FornecedorDto fornecedorDto);
        FornecedorEntity EditarDadosFornecedor(int id, FornecedorDto fornecedorDto);
        void DeletarDadosFornecedor(int id);  
    }
}