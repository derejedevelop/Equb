namespace Equb.Interfaces.Repositories
{
    public interface IMemberInviteRepository
    {
        void Add<T>(T entity) where T : class;
        Task<bool> SaveAll();
    }
}
