namespace Equb.Interfaces.Repositories
{
    public interface ICommonRepository
    {
        void Add<T>(T entity) where T : class;
        Task<bool> SaveAll();
    }
}
