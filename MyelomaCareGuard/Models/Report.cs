namespace MyelomaCareGuard.Models
{
    public class Report
    {
        public int Id { get; set; }
        public string UserId { get; set; } = "";
        public ReportType Type { get; set; }
        public string FileName { get; set; } = "";
        public string FilePath { get; set; } = "";
        public DateTime Date { get; set; }
    }
}
