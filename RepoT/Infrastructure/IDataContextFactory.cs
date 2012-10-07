using System;

namespace RepoT.Infrastructure
{
    public interface IDataContextFactory<out TContext> : IDisposable where TContext : IDisposable
    {
        TContext GetContext();
    }
}