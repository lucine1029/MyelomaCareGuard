using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyelomaCareGuard.Models;

namespace MyelomaCareGuard.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Record> Records { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
    }
}
