using MyelomaCareGuard.Models;

namespace MyelomaCareGuard.Services.Interfaces
{
    public interface IReminderService
    {
        Task AddAsync(Reminder reminder);
        Task<List<Reminder>> GetByUserAsync(string userId);
        Task UpdateAsync(Reminder reminder);
        Task DeleteAsync(int id);
    }
}
