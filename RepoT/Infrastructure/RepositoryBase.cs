using System;

namespace RepoT.Infrastructure
{
    public abstract class RepositoryBase<TContext> where TContext : class,IDisposable
    {
        private TContext _dataContext;

        protected RepositoryBase(IDatabaseFactory<TContext> databaseFactory)
        {
            DatabaseFactory = databaseFactory;
        }

        protected IDatabaseFactory<TContext> DatabaseFactory { get; private set; }

        protected TContext DataContext
        {
            get { return _dataContext ?? (_dataContext = DatabaseFactory.Get()); }
        }
    }
}