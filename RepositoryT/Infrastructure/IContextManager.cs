namespace RepositoryT.Infrastructure
{
    public interface IContextManager
    {
        void Create();
        void Release();
    }
}