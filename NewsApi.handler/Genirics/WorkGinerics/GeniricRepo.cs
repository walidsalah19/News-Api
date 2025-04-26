using Microsoft.EntityFrameworkCore;
using NewsApi.Domain.AppEntity;
using NewsApi.handler.Genirics.Interface;
using NewsApi.infstructure.AppInfa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.handler.Genirics.WorkGinerics
{
    public class GeniricRepo<T> : IGeniricRepo<T> where T : BaseEntity
    {
        private readonly AppDbContext context;

        public GeniricRepo(AppDbContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(T item) => await context.Set<T>().AddAsync(item);

        public void DeleteAsync(T item)
        {
            context.Set<T>().Remove(item);
        }

        public async Task<IEnumerable<T>> GetAllWithAsync()
        {
           return await context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T?> GetbyIdAsync(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public void Update(T item)
        {
            context.Set<T>().Update(item);
        }
    }
}
