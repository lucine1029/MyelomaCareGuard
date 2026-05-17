using Microsoft.EntityFrameworkCore;
using MyelomaCareGuard.Data;
using MyelomaCareGuard.Models;
using MyelomaCareGuard.Services.Interfaces;

namespace MyelomaCareGuard.Services
{
    public class RecordService : IRecordService
    {
        private readonly ApplicationDbContext _context;
        public RecordService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Record record)
        {
            _context.Records.Add(record);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Record>> GetByUserAsync(string userId)
        {
            return await _context.Records
                .Where(r => r.UserId == userId)
                .OrderByDescending(r => r.Date)
                .ToListAsync();
        }

        public async Task UpdateAsync(Record record)
        {
            _context.Records.Update(record);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var record = await _context.Records.FindAsync(id);

            if (record != null)
            {
                _context.Records.Remove(record);
                await _context.SaveChangesAsync();
            }
        }
    }
}
