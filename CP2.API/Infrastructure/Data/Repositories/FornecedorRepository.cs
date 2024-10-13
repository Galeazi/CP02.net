using CP2.API.Infrastructure.Data.AppData;
using CP2.API.Domain.Entities;
using CP2.API.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CP2.API.Infrastructure.Data.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly ApplicationContext _context;

        public FornecedorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Add(FornecedorEntity fornecedor)
        {
            _context.Fornecedor.Add(fornecedor);
            _context.SaveChanges();
        }

        public void Update(FornecedorEntity fornecedor)
        {
            _context.Fornecedor.Update(fornecedor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var fornecedor = _context.Fornecedor.Find(id);
            if (fornecedor != null)
            {
                _context.Fornecedor.Remove(fornecedor);
                _context.SaveChanges();
            }
        }

        public FornecedorEntity GetById(int id)
        {
            return _context.Fornecedor.Find(id);
        }

        public IEnumerable<FornecedorEntity> GetAll()
        {
            return _context.Fornecedor.ToList();
        }
    }
}