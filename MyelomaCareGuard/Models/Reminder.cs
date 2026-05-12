namespace MyelomaCareGuard.Models
{
    public class Reminder
    {
        public int Id { get; set; }
        public string UserId { get; set; } = "";
        public string Title { get; set; } = "";
        public ReminderType Type { get; set; }
        public TimeSpan Time { get; set; }
        public List<string> Days { get; set; } = new();
    }
}
