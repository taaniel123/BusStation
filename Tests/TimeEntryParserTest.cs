using BusStation.Models;
using BusStation.Services;
using Xunit;

namespace BusStation.Tests
{
    public class TimeEntryParserTest
    {
        [Fact]
        public void ParseAndAddEntry_ValidEntry_AddsEntry()
        {
            var timeEntries = new List<TimeEntry>();
            var line = "12:00-13:00";

            var result = TimeEntryParser.ParseAndAddEntry(timeEntries, line);

            Assert.True(result);
            Assert.Single(timeEntries);
            Assert.Equal(new TimeSpan(12, 0, 0), timeEntries[0].Start.TimeOfDay);
            Assert.Equal(new TimeSpan(13, 0, 0), timeEntries[0].End.TimeOfDay);
        }

        [Theory]
        [InlineData("invalid")]
        [InlineData("08:00")]
        [InlineData("08:00-09:00-10:00")]
        [InlineData("08:00-xx:xx")]
        public void ParseAndAddEntry_InvalidEntry_ReturnsFalse(string line)
        {
            var timeEntries = new List<TimeEntry>();

            var result = TimeEntryParser.ParseAndAddEntry(timeEntries, line);

            Assert.False(result);
            Assert.Empty(timeEntries);
        }
    }
}
