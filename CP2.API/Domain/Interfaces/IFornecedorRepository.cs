using CP2.API.Domain.Entities;
using System.Collections.Generic;

namespace CP2.API.Domain.Interfaces
{
    public interface IFornecedorRepository
    {
        void Add(FornecedorEntity fornecedor);                 
        void Update(FornecedorEntity fornecedor);             
        void Delete(int id);                                   
        FornecedorEntity GetById(int id);               
        IEnumerable<FornecedorEntity> GetAll();              
    }
}