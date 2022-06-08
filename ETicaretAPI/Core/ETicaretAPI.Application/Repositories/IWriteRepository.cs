using ETicaretAPI.Domain.Entities.Common;

namespace ETicaretAPI.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T model);

        Task<bool> AddRangeAsync(List<T> model);

        bool Remove(T model);

        Task<bool> Remove(string id);

        Task<bool> UpdateAsync(T model);

        Task<int> SaveAsync();
    }
}