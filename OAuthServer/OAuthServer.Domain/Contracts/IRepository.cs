using System;
using System.Collections.Generic;

namespace OAuthServer.Domain.Contracts
{
    public interface IRepository<T> : IDisposable
        where T : class
    {
        ICollection<T> Get();
        T Get(int id);
        void SaveOrUpdate(T entity);
        void Delete(int id);
    }
}
