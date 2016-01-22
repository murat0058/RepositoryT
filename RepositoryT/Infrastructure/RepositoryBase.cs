using System;

namespace RepositoryT.Infrastructure
{
    public abstract class RepositoryBase<TContext> where TContext : class,IDisposable
    {
        private readonly IDependencyResolverAdapter _resolver;

        protected RepositoryBase(IDependencyResolverAdapter resolver)
        {
            _resolver = resolver;
        }

        protected internal TContext DataContext
        {
            get { return ((IDataContextFactory<TContext>)_resolver.GetService(typeof(IDataContextFactory<TContext>))).GetContext(); }
        }
    }
}