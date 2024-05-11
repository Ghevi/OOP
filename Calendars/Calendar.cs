using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendars;

internal abstract class Calendar
{
    public abstract bool IsLeapYear(int year);
    public abstract bool IsLeapDay(int month, int day);
    public abstract int DaysInMonth(int month);
    public abstract int NextMonth(int month);
}
