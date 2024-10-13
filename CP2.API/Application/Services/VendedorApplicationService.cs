using CP2.API.Application.Interfaces;
using CP2.API.Application.Dtos;
using CP2.API.Domain.Entities;
using CP2.API.Domain.Interfaces;
using System.Collections.Generic;

namespace CP2.API.Application.Services
{
    public class VendedorApplicationService : IVendedorApplicationService
    {
        private readonly IVendedorRepository _repository;

        public VendedorApplicationService(IVendedorRepository repository)
        {
            _repository = repository;
        }

        public VendedorEntity? ObterVendedorPorId(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<VendedorEntity> ObterTodosVendedores()
        {
            return _repository.GetAll();
        }

        public VendedorEntity SalvarDadosVendedor(VendedorDto vendedorDto)
        {
            var vendedor = new VendedorEntity
            {
                Nome = vendedorDto.Nome,
                Email = vendedorDto.Email,
                Telefone = vendedorDto.Telefone,
                DataNascimento = vendedorDto.DataNascimento,
                Endereco = vendedorDto.Endereco,
                DataContratacao = vendedorDto.DataContratacao,
                ComissaoPercentual = vendedorDto.ComissaoPercentual,
                MetaMensal = vendedorDto.MetaMensal
            };
            _repository.Add(vendedor);
            return vendedor;
        }

        public VendedorEntity EditarDadosVendedor(int id, VendedorDto vendedorDto)
        {
            var vendedor = _repository.GetById(id);
            if (vendedor != null)
            {
                vendedor.Nome = vendedorDto.Nome;
                vendedor.Email = vendedorDto.Email;
                vendedor.Telefone = vendedorDto.Telefone;
                vendedor.DataNascimento = vendedorDto.DataNascimento;
                vendedor.Endereco = vendedorDto.Endereco;
                vendedor.DataContratacao = vendedorDto.DataContratacao;
                vendedor.ComissaoPercentual = vendedorDto.ComissaoPercentual;
                vendedor.MetaMensal = vendedorDto.MetaMensal;
                _repository.Update(vendedor);
            }
            return vendedor;
        }

        public void DeletarDadosVendedor(int id)
        {
            _repository.Delete(id);
        }
    }
}
