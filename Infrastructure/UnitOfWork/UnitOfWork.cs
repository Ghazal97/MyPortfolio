using Core;
using System;

namespace Infrastructure.Repositories
{
  public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly DataContext _context;

        private IGenericRepository<T> _entity;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }
        public IGenericRepository<T> genericRepository
        {
            get
            {
                return _entity ?? (_entity = new GenericRepository<T>(_context));
            }
        }

        //public IGenericRepository<T> genericRepository => throw new NotImplementedException();

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}