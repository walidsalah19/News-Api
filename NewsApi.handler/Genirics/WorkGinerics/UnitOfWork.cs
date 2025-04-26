using Microsoft.EntityFrameworkCore;
using NewsApi.Domain.AppEntity;
using NewsApi.handler.Genirics.Interface;
using NewsApi.infstructure.AppInfa;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.handler.Genirics.WorkGinerics
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;
        private Hashtable Repo;

        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            Repo = new Hashtable();
        }

        public async Task<int> CompleteAsync() => await _dbContext.SaveChangesAsync();

        public void Detach<T>(T entity) where T : BaseEntity
        {
            _dbContext.Entry(entity).State = EntityState.Detached;
        }

        public ValueTask DisposeAsync()=>_dbContext.DisposeAsync();
        public IGeniricRepo<T> Repository<T>() where T : BaseEntity
        {
            var type = typeof(T).Name;
            if (!Repo.ContainsKey(type))
            {
                var repository = new GeniricRepo<T>(_dbContext);
                Repo.Add(type, repository);
            }
            return (IGeniricRepo<T>)Repo[type]!;
        }
    }
}
