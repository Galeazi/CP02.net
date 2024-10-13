using CP2.API.Application.Dtos;
using CP2.API.Domain.Entities;
using System.Collections.Generic;

namespace CP2.API.Application.Interfaces
{
    public interface IVendedorApplicationService
    {
        VendedorEntity? ObterVendedorPorId(int id);
        IEnumerable<VendedorEntity> ObterTodosVendedores();
        VendedorEntity SalvarDadosVendedor(VendedorDto vendedorDto);
        VendedorEntity EditarDadosVendedor(int id, VendedorDto vendedorDto);
        void DeletarDadosVendedor(int id);  
    }
}