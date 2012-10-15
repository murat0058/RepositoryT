using System;

namespace RepositoryT.Infrastructure
{
    public abstract class RepositoryBase<TContext> where TContext : class,IDisposable
    {
        private TContext _dataContext;
        protected IDataContextFactory<TContext> DataContextFactory { get; private set; }

        protected RepositoryBase(IDataContextFactory<TContext> dataContextFactory)
        {
            DataContextFactory = dataContextFactory;
        }

        protected TContext DataContext
        {
            get { return _dataContext ?? (_dataContext = DataContextFactory.GetContext()); }
        }
    }
}