using BusStation.Models;

namespace BusStation.Services
{
    public static class FileReader
    {
        public static void LoadTimeEntriesFromFile(string filePath, List<TimeEntry> timeEntries)
        {
            try
            {
                using var reader = new StreamReader(filePath);
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    TimeEntryParser.ParseAndAddEntry(timeEntries, line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error reading file: {e.Message}");
            }
        }
    }
}
