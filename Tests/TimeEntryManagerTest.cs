using BusStation.Models;
using BusStation.Services;
using Xunit;

namespace BusStation.Tests
{
    public class TimeEntryManagerTest
    {
        [Fact]
        public void CalculateAndDisplayBusiestTime_CorrectlyCalculatesBusiestTime()
        {
            var timeEntries = new List<TimeEntry>
            {
                new(new DateTime(2024, 8, 1, 10, 0, 0), new DateTime(2024, 8, 1, 11, 0, 0)),
                new(new DateTime(2024, 8, 1, 10, 30, 0), new DateTime(2024, 8, 1, 11, 30, 0)),
                new(new DateTime(2024, 8, 1, 11, 0, 0), new DateTime(2024, 8, 1, 12, 0, 0))
            };

            var (start, end, count) = BreakCalculator.CalculateBusiestTime(timeEntries);

            Assert.Equal(new DateTime(2024, 8, 1, 10, 30, 0), start);
            Assert.Equal(new DateTime(2024, 8, 1, 11, 0, 0), end);
            Assert.Equal(2, count);
        }
    }
}
