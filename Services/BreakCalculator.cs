using BusStation.Models;

namespace BusStation.Services
{
    public class BreakCalculator
    {
        public static (DateTime start, DateTime end, int count) CalculateBusiestTime(List<TimeEntry> timeEntries)
        {
            // Sorting time entries by start time
            timeEntries.Sort((x, y) => x.Start.CompareTo(y.Start));

            // Creating a list of events (start and end times)
            List<(DateTime time, bool isStart)> events = [];
            foreach (var entry in timeEntries)
            {
                events.Add((entry.Start, true));
                events.Add((entry.End, false));
            }

            // Sorting events by time
            events.Sort((x, y) => x.time.CompareTo(y.time));

            int currentDrivers = 0;
            int maxDrivers = 0;
            DateTime busiestStart = DateTime.MinValue;
            DateTime busiestEnd = DateTime.MinValue;
            bool inBusiestPeriod = false;

            foreach (var (time, isStart) in events)
            {
                if (isStart)
                {
                    currentDrivers++;
                    if (currentDrivers > maxDrivers)
                    {
                        maxDrivers = currentDrivers;
                        busiestStart = time;
                        busiestEnd = time;
                        inBusiestPeriod = true;
                    }
                }
                else
                {
                    currentDrivers--;
                    if (inBusiestPeriod && currentDrivers < maxDrivers)
                    {
                        inBusiestPeriod = false;
                        busiestEnd = time;
                    }
                }
            }
            return (busiestStart, busiestEnd, maxDrivers);
        }
    }
}