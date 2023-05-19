namespace Equb.Interfaces.Repositories
{
    public interface IEqubRepository
    {
        void Add<T>(T entity) where T : class;
        Task<bool> SaveAll();
    }
}
