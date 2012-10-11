using System;

namespace RepositoryT.Infrastructure
{
    public abstract class UnitOfWorkBase<TContext> : IUnitOfWork where TContext : class ,IDisposable
    {
        private readonly IDataContextFactory<TContext> _dataContextFactory;
        private TContext _dataContext;

        protected UnitOfWorkBase(IDataContextFactory<TContext> dataContextFactory)
        {
            _dataContextFactory = dataContextFactory;
        }

        protected TContext DataContext
        {
            get { return _dataContext ?? (_dataContext = _dataContextFactory.GetContext()); }
        }

        #region IUnitOfWork Members

        public abstract void Commit();

        #endregion
    }
}