namespace MyelomaCareGuard.DTOs
{
    public class ChartPoint
    {
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
        public string Label => Date.ToString("MM-dd");
    }
}
