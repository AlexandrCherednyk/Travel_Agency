using System;

namespace UIL.Models
{
    public class TimePeriodViewModel
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public TimePeriodViewModel(DateTime start, DateTime end)
        {
            Start = (start < end) ? start : end;
            End = (start < end) ? end : start;
        }

        public bool IsInterset(DateTime start, DateTime end)
        {
            return (start > Start & start < End)
                || (end > Start & end < End)
                || (start < Start & end > End)
                || (start == Start & end == End);
        }

        public bool IsInterset(TimePeriodViewModel period)
        {
            return (period.Start > Start & period.Start < End)
                || (period.End > Start & period.End < End)
                || (period.Start < Start & period.End > End)
                || (period.Start == Start & period.End == End);
        }

        public static bool IsInterset(TimePeriodViewModel firstPeriod, TimePeriodViewModel secondPeriod)
        {
            return (firstPeriod.Start > secondPeriod.Start && firstPeriod.Start < secondPeriod.End)
                || (firstPeriod.End > secondPeriod.Start && firstPeriod.End < secondPeriod.End)
                || (firstPeriod.Start < secondPeriod.Start && firstPeriod.End > secondPeriod.End)
                || (firstPeriod.Start == secondPeriod.Start && firstPeriod.End == secondPeriod.End);
        }

        public void ChangeDate (DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }

        public int GetNightsNumber()
        {
            return (End - Start).Days;
        }
        public int GetDaysNumberToStart(DateTime dateTime)
        {
            if (dateTime > Start)
                return (dateTime - Start).Days;

            return (Start - dateTime).Days;
        }

        public override string ToString()
        {
            return $"Time period: Start: {Start.Date:d}, End: {End.Date:d}";
        }
    }
}
