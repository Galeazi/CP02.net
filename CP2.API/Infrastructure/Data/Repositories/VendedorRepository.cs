using CP2.API.Infrastructure.Data.AppData;
using CP2.API.Domain.Entities;
using CP2.API.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CP2.API.Infrastructure.Data.Repositories
{
    public class VendedorRepository : IVendedorRepository
    {
        private readonly ApplicationContext _context;

        public VendedorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Add(VendedorEntity vendedor)
        {
            _context.Vendedor.Add(vendedor);
            _context.SaveChanges();
        }

        public void Update(VendedorEntity vendedor)
        {
            _context.Vendedor.Update(vendedor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var vendedor = _context.Vendedor.Find(id);
            if (vendedor != null)
            {
                _context.Vendedor.Remove(vendedor);
                _context.SaveChanges();
            }
        }

        public VendedorEntity GetById(int id)
        {
            return _context.Vendedor.Find(id);
        }

        public IEnumerable<VendedorEntity> GetAll()
        {
            return _context.Vendedor.ToList();
        }
    }
}