using CP2.API.Application.Interfaces;
using CP2.API.Application.Dtos;
using CP2.API.Domain.Entities;
using CP2.API.Domain.Interfaces;
using System.Collections.Generic;

namespace CP2.API.Application.Services
{
    public class FornecedorApplicationService : IFornecedorApplicationService
    {
        private readonly IFornecedorRepository _repository;

        public FornecedorApplicationService(IFornecedorRepository repository)
        {
            _repository = repository;
        }

        public FornecedorEntity? ObterFornecedorPorId(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<FornecedorEntity> ObterTodosFornecedores()
        {
            return _repository.GetAll();
        }

        public FornecedorEntity SalvarDadosFornecedor(FornecedorDto fornecedorDto)
        {
            var fornecedor = new FornecedorEntity
            {
                Nome = fornecedorDto.Nome,
                CNPJ = fornecedorDto.CNPJ,
                Endereco = fornecedorDto.Endereco,
                Telefone = fornecedorDto.Telefone,
                Email = fornecedorDto.Email
            };
            _repository.Add(fornecedor);
            return fornecedor;
        }

        public FornecedorEntity EditarDadosFornecedor(int id, FornecedorDto fornecedorDto)
        {
            var fornecedor = _repository.GetById(id);
            if (fornecedor != null)
            {
                fornecedor.Nome = fornecedorDto.Nome;
                fornecedor.CNPJ = fornecedorDto.CNPJ;
                fornecedor.Endereco = fornecedorDto.Endereco;
                fornecedor.Telefone = fornecedorDto.Telefone;
                fornecedor.Email = fornecedorDto.Email;
                _repository.Update(fornecedor);
            }
            return fornecedor;
        }

        public void DeletarDadosFornecedor(int id)
        {
            _repository.Delete(id);
        }
    }
}