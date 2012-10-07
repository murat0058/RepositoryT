namespace RepoT.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}