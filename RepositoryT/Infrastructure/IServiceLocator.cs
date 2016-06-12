using System;
using System.Collections.Generic;

namespace RepositoryT.Infrastructure
{
    public interface IServiceLocator
    {
        object GetService(Type serviceType);

        IEnumerable<object> GetServices(Type serviceType);
    }
}