using BusStation.Models;
using BusStation.Services;

namespace BusStation
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<TimeEntry> timeEntries = [];

            if (args.Length > 0)
            {
                FileReader.LoadTimeEntriesFromFile(args[0], timeEntries);
            }

            if (timeEntries.Count > 0)
            {
                TimeEntryManager.CalculateAndDisplayBusiestTime(timeEntries);
            }

            ConsoleReader.ReadTimeEntriesFromConsole(timeEntries);
        }
    }
}