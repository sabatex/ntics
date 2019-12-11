
using ntics.ClassExtensions;
using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;

namespace ntics.DateTimeExtensions
{
    [TypeConverter(typeof(DateTimePeriodConverter))]
    public class DateTimePeriod :ObservableObject
    {
        DateTime? begin;
        DateTime? end;
        public virtual DateTime? Begin { get => begin; set => SetProperty(ref begin, value); }
        public virtual DateTime? End { get=>end; set=>SetProperty(ref end,value);}

        /// <summary>
        /// Max years range
        /// </summary>
        public readonly int MaxRange = 255;

        public DateTimePeriod(){ }
        public DateTimePeriod(DateTime date) : this(date.BeginOfDay(), date.EndOfDay()) { }
        public DateTimePeriod(DateTime? beginDate, DateTime? endDate)
        {
            Begin = beginDate;
            End = endDate;
        }

        public static DateTimePeriod GetDay(DateTime date) => new DateTimePeriod(date.BeginOfDay(), date.EndOfDay());
        public static DateTimePeriod GetMonth(DateTime date) => new DateTimePeriod(date.BeginOfMonth(), date.EndOfMonth());
        public static DateTimePeriod GetQuarter(DateTime date) => new DateTimePeriod(date.BeginOfQuarter(), date.EndOfQuarter());
        public static DateTimePeriod GetYear(DateTime date) => new DateTimePeriod(date.BeginOfYear(), date.EndOfYear());
        public static DateTimePeriod GetWeek(DateTime date) => new DateTimePeriod(date.BeginOfWeek(), date.EndOfWeek());

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var p = (DateTimePeriod)obj;
            return ((this.Begin == p.Begin) && (this.End == p.End));
        }

        /// <summary>
        /// 14 bit Begin.Year 8 bit (Range years ) 9 bit (range days)
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            if (Begin == null)
            {
                if (End == null) return 0x4e7e0000;
                return 0x4e5e0000 | (End.Value.Year * 366 + End.Value.DayOfYear);
            }
            else
            {

                if (End == null) return 0x4e3e0000 | (Begin.Value.Year * 366 + Begin.Value.DayOfYear);
                return (Begin.Value.Year << 17) | (((End.Value.Year * 366 + End.Value.DayOfYear) - (Begin.Value.Year * 366 + Begin.Value.DayOfYear)) & 0x1FFFF);
            }
        }

        public static bool operator ==(DateTimePeriod arg1, DateTimePeriod arg2)
        {
            if (arg1 == null) return arg2 == null;
            return arg1.Equals(arg2);
        }

        public static bool operator !=(DateTimePeriod arg1, DateTimePeriod arg2)
        {
            if (arg1 == null) return arg2 != null;
            return !arg1.Equals(arg2);
        }

        public override string ToString()
        {
            var s1 = Begin == null ? "null" : Begin.Value.ToShortDateString();
            var s2 = End == null ? "null" : End.Value.ToShortDateString();
            return string.Format("Period from {0} to {1}", s1, s2);
        }
    }

}

