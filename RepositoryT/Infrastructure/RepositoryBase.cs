using System;

namespace RepositoryT.Infrastructure
{
    public abstract class RepositoryBase<TContext> where TContext : class,IDisposable
    {
        private TContext _dataContext;

        protected RepositoryBase(IDataContextFactory<TContext> dataContextFactory)
        {
            DataContextFactory = dataContextFactory;
        }

        protected IDataContextFactory<TContext> DataContextFactory { get; private set; }

        protected TContext DataContext
        {
            get { return _dataContext ?? (_dataContext = DataContextFactory.GetContext()); }
        }
    }
}