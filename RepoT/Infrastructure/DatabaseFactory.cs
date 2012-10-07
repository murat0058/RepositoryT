using System;

namespace RepoT.Infrastructure
{
    public class DatabaseFactory<TContext> : Disposable, IDatabaseFactory<TContext> where TContext : class, IDisposable, new()
    {
        private TContext _dataContext;

        #region IDatabaseFactory Members

        public TContext Get()
        {
            return _dataContext ?? (_dataContext = new TContext());
        }

        #endregion

        protected override void DisposeCore()
        {
            if (_dataContext != null)
                _dataContext.Dispose();
        }
    }
}