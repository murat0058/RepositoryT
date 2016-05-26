using System;

namespace RepositoryT.Infrastructure
{
    public interface IContextManager : IDisposable
    {
        void Create();
        void Release();
    }
}