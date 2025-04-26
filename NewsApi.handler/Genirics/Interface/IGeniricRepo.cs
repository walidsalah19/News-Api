using NewsApi.Domain.AppEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.handler.Genirics.Interface
{
    public interface IGeniricRepo<T> where T:BaseEntity
    {
        Task<T> GetbyIdAsync(int id);

        Task<IEnumerable<T>> GetAllWithAsync();

        Task AddAsync(T item);

        void DeleteAsync(T item);

        void Update(T item);
    }
}
