using NewsApi.Domain.AppEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.handler.Genirics.Interface
{
    public interface IUnitOfWork: IAsyncDisposable
    {

        Task<int> CompleteAsync();

        IGeniricRepo<T> Repository<T>() where T : BaseEntity;

        void Detach<T>(T entity) where T : BaseEntity;
    }
}
