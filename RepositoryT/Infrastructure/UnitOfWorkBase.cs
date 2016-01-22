using System;

namespace RepositoryT.Infrastructure
{
    public abstract class UnitOfWorkBase<TContext> : IUnitOfWork where TContext : class ,IDisposable
    {
        private readonly IDependencyResolverAdapter _resolver;

        protected UnitOfWorkBase(IDependencyResolverAdapter resolver)
        {
            _resolver = resolver;

        }

        protected TContext DataContext
        {
            get
            {
                var contextFactory = ((IDataContextFactory<TContext>)_resolver.GetService(typeof(IDataContextFactory<TContext>)));
                return contextFactory.GetContext();
            }
        }


        public abstract void Commit();
    }
}