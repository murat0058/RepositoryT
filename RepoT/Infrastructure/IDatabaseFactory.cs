using System;

namespace RepoT.Infrastructure
{
    public interface IDatabaseFactory<out TContext> : IDisposable where TContext : IDisposable
    {
        TContext Get();
    }
}