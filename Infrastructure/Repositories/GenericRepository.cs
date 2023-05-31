using Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DataContext _context;

        public DbSet<T> table = null;
        public GenericRepository(DataContext dataContext)
        {
            _context = dataContext;
            table = _context.Set<T>();
        }

        public void CreateEntity(T t)
        {
            table.Add(t);
        }

        public void DeleteEntity(object id)
        {
            var obj = GetById(id);
            table.Remove(obj);
        }

        public IEnumerable<T> GetAllEntities()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void UpdateEntity(T t)
        {
            table.Attach(t);
            _context.Entry(t).State = EntityState.Modified;
        }
    }
}