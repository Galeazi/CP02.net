using CP2.API.Domain.Entities;
using System.Collections.Generic;

namespace CP2.API.Domain.Interfaces
{
    public interface IVendedorRepository
    {
        void Add(VendedorEntity vendedor);               
        void Update(VendedorEntity vendedor);                  
        void Delete(int id);                                  
        VendedorEntity GetById(int id);                        
        IEnumerable<VendedorEntity> GetAll();                 
    }
}