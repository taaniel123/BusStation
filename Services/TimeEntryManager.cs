using BusStation.Models;

namespace BusStation.Services
{
    public static class TimeEntryManager
    {
        public static void CalculateAndDisplayBusiestTime(List<TimeEntry> timeEntries)
        {
            (DateTime start, DateTime end, int count) = BreakCalculator.CalculateBusiestTime(timeEntries);
            Console.WriteLine($"Current busiest time: {start:HH:mm} - {end:HH:mm}, drivers: {count}. Add another time or type 'exit' to finish.");
        }
    }
}
