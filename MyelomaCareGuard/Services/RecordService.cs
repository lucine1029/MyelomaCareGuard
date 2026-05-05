using Microsoft.EntityFrameworkCore;
using MyelomaCareGuard.Data;
using MyelomaCareGuard.Models;

namespace MyelomaCareGuard.Services
{
    public class RecordService
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
    }
}
