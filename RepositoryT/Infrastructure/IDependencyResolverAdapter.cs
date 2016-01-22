using System;
using System.Collections.Generic;

namespace RepositoryT.Infrastructure
{
    public interface IDependencyResolverAdapter
    {
        object GetService(Type serviceType);
        IEnumerable<object> GetServices(Type serviceType);
    }
}