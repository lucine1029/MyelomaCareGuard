using Microsoft.EntityFrameworkCore;
using MyelomaCareGuard.Data;
using MyelomaCareGuard.Models;
using MyelomaCareGuard.Services.Interfaces;

namespace MyelomaCareGuard.Services
{
    public class ReminderService: IReminderService
    {
        private readonly ApplicationDbContext _context;

        public ReminderService(ApplicationDbContext context)
        {
            _context = context;
        }

        // ADD reminder
        public async Task AddAsync(Reminder reminder)
        {
            _context.Reminders.Add(reminder);
            await _context.SaveChangesAsync();
        }

        // GET reminders for one user
        public async Task<List<Reminder>> GetByUserAsync(string userId)
        {
            return await _context.Reminders
                .Where(r => r.UserId == userId)
                .OrderBy(r => r.Time)
                .ToListAsync();
        }

        // UPDATE
        public async Task UpdateAsync(Reminder reminder)
        {
            _context.Reminders.Update(reminder);
            await _context.SaveChangesAsync();
        }

        // DELETE
        public async Task DeleteAsync(int id)
        {
            var reminder = await _context.Reminders.FindAsync(id);

            if (reminder != null)
            {
                _context.Reminders.Remove(reminder);
                await _context.SaveChangesAsync();
            }
        }
    }
}