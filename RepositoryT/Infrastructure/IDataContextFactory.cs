using System;

namespace RepositoryT.Infrastructure
{
    public interface IDataContextFactory<out TContext> : IDisposable where TContext : IDisposable
    {
        TContext GetContext();
        void Create();
        void Release();
    }
}