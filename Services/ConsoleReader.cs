using BusStation.Models;

namespace BusStation.Services
{
    public static class ConsoleReader
    {
        public static void ReadTimeEntriesFromConsole(List<TimeEntry> timeEntries)
        {
            Console.WriteLine("Enter time entries in the format HH:mm-HH:mm (type 'exit' to finish):");
            while (true)
            {
                var line = Console.ReadLine();
                if (line == null)
                {
                    continue;
                }
                
                if (string.Equals(line, "exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                if (TimeEntryParser.ParseAndAddEntry(timeEntries, line))
                {
                    TimeEntryManager.CalculateAndDisplayBusiestTime(timeEntries);
                }
                else
                {
                    Console.WriteLine($"Invalid time entry: {line}");
                }
            }
        }
    }
}
