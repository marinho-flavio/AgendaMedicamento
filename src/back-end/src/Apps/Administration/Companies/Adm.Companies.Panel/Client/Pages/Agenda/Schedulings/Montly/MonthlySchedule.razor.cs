using SES.Companies.Application.DTO.Aggregates.SchedulingsAgg.Requests;
using Syncfusion.Blazor.RichTextEditor.Internal;
using Syncfusion.Blazor.Schedule.Internal;

namespace Companies.Adm.Panel.Client.Pages.Agenda.Schedulings.Montly
{
    public class MyDayInfo
    {
        public MyDayInfo(string clss, DateOnly myDate, bool isHoliday)
        {
            Clss = clss;
            MyDate = myDate;
            IsHoliday = isHoliday;
        }

        public string Color { get; set; }
        public DateOnly MyDate { get; set; }
        public string Clss { get; set; }
        public MonthlyScheduleDateType Type { get; set; }
        public bool IsHoliday { get; set; }

        public string Day
        {
            get
            {
                return $"{(MyDate.Day < 10 ? "0" : "")}{(MyDate.Day.ToString() ?? "...")}";
            }
        }
    }
    public enum MonthlyScheduleDateType
    {
        LastMonth,
        CurrentMonth,
        NexeMonth
    }
    public interface IMonthlyScheduleContext
    {
        public MyDayInfo MyDate(int i);
    }
    public class MonthlyScheduleContext : IMonthlyScheduleContext
    {
        public FeriadoListiningDTO[] Holidays { get; set; }
        public int CurrentMonth { get; set; }
        public int CurrentYear { get; set; }
    
        public int qtdDaysBeforeCurrentMonth
        {
            get
            {
                return LastMonthDaysCount - LastSundayInLastMonth.Day;
            }
        }


        public DateTime LastSundayInLastMonth
        {
            get
            {
                var date = new DateTime(this.CurrentYear, this.CurrentMonth - 1 <= 0 ? 1 : this.CurrentMonth - 1, LastMonthDaysCount);
                
                for (int i = date.Day; i > 0; i--)
                {
                    if (date.DayOfWeek == DayOfWeek.Sunday) return date;
                    date = date.AddDays(-1);
                }
                throw new Exception($"Error calculating date: " + date);
            }
        }

        public int LastMonthDaysCount
        {
            get
            {
                return DateTime.DaysInMonth(this.CurrentYear, this.CurrentMonth - 1 <= 0? 1 : this.CurrentMonth - 1);
            }
        }
        public int CurrentMonthDaysCount
        {
            get
            {
                return DateTime.DaysInMonth(this.CurrentYear, this.CurrentMonth);
            }
        }


        public MonthlyScheduleContext(FeriadoListiningDTO[] holidays, int year, int month)
        {
            Holidays = holidays;
            this.CurrentMonth = month;
            this.CurrentYear = year;
        }

        public MyDayInfo MyDate(int i)
        {
            var month = this.CurrentMonth;
            var year = this.CurrentYear;
            int initialI = i;
            string clss;
            MonthlyScheduleDateType type;

            if (i < this.qtdDaysBeforeCurrentMonth)
            {
                clss = "last-month";
                type = MonthlyScheduleDateType.LastMonth;
                month--; i = this.LastMonthDaysCount - this.qtdDaysBeforeCurrentMonth + i + 1;
            }
            else if (i - this.qtdDaysBeforeCurrentMonth >= this.CurrentMonthDaysCount)
            {
                clss = "next-month";
                type = MonthlyScheduleDateType.NexeMonth;
                month++; i = i - this.CurrentMonthDaysCount - this.qtdDaysBeforeCurrentMonth + 1;
            }
            else
            {
                clss = "current-month";
                type = MonthlyScheduleDateType.CurrentMonth;
                i = i - this.qtdDaysBeforeCurrentMonth + 1;
            }

            if (month <= 0) { month = 1; year--; }
            if (month >= 13) { month = 1; year++; }

            var myDate = new DateOnly(year, month, i == 0 ? 1 : i);
            var isHoliday = this.Holidays.Any(x => x.Data == myDate);
            try
            {
                return new MyDayInfo(clss, myDate, isHoliday);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
