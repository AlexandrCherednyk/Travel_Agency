using Microsoft.EntityFrameworkCore;
using System;

namespace DAL.Entities
{
    [Owned]
    public class TimePeriod
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public TimePeriod() { }
        public TimePeriod(DateTime start, DateTime end)
        {
            Start = (start < end) ? start : end;
            End = (start < end) ? end : start;
        }
        public int GetNightsNumber()
        {
            return (End - Start).Days;
        }
    }
}
