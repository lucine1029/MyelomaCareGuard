using MyelomaCareGuard.Models;

namespace MyelomaCareGuard.Services.Interfaces
{
    public interface IRecordService
    {
        Task AddAsync(Record record);

        Task<List<Record>> GetByUserAsync(string userId);

        Task UpdateAsync(Record record);

        Task DeleteAsync(int id);
    }
}
