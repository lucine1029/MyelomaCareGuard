using MyelomaCareGuard.Models;

namespace MyelomaCareGuard.Services.Interfaces
{
    public interface IBookingService
    {
        Task AddAsync(Booking booking);

        Task<List<Booking>> GetByUserAsync(string userId);

        Task DeleteAsync(int id);

        Task UpdateAsync(Booking booking);
    }
}