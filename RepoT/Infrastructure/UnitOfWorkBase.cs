using System;

namespace RepoT.Infrastructure
{
    public abstract class UnitOfWorkBase<TContext> : IUnitOfWork where TContext : class ,IDisposable
    {
        private readonly IDatabaseFactory<TContext> _databaseFactory;
        private TContext _dataContext;

        protected UnitOfWorkBase(IDatabaseFactory<TContext> databaseFactory)
        {
            _databaseFactory = databaseFactory;
        }

        protected TContext DataContext
        {
            get { return _dataContext ?? (_dataContext = _databaseFactory.Get()); }
        }

        #region IUnitOfWork Members

        public abstract void Commit();

        #endregion
    }
}