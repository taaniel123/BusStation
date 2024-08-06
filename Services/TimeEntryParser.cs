using System.Globalization;
using BusStation.Models;

namespace BusStation.Services
{
    public static class TimeEntryParser
    {
        // Parsing the line into a TimeEntry object
        public static bool ParseAndAddEntry(List<TimeEntry> timeEntries, string line)
        {
            string[] parts = line.Split('-');
            if (parts.Length == 2 &&
                DateTime.TryParseExact(parts[0], "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime start) &&
                DateTime.TryParseExact(parts[1], "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime end))
            {
                timeEntries.Add(new TimeEntry(start, end));
                return true;
            }
            return false;
        }
    }
}
