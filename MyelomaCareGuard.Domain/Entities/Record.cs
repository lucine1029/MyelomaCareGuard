namespace MyelomaCareGuard.Domain.Entities
{
    public class Record
    {
        public int Id { get; set; }
        public string UserId { get; set; } = "";
        public RecordType Type { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }
    }
}
