namespace BusStation.Models
{
    public class TimeEntry(DateTime start, DateTime end)
    {
        public DateTime Start { get; set; } = start;
        public DateTime End { get; set; } = end;
    }
}
