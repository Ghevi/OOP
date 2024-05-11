using System;

namespace Calendars;

class Date
{
    private int _year;
    private YearDate _day;
    private Calendar _calendar;

    public Date(Calendar calendar, int year, YearDate day)
    {
        _calendar = calendar;
        _year = year;
        _day = day;
    }

    public Date AddYears(int count) =>
        FirstValidDate(_year + count, _day);

    private Date FirstValidDate(int year, YearDate day) =>
        _calendar.IsLeapDay(day) && !_calendar.IsLeapYear(year) ? new Date(_calendar, year, day.GetNext())
        : new Date(_calendar, year, day);

    public Date GetFirstDayOccurrence(Date day) =>
        GetFirstDayOccurrence(_year, day._day);

    public Date GetFirstOccurrence(YearDate day) =>
        GetFirstDayOccurrence(day.IsBefore(_day) ? _year + 1 : _year, day);

    private Date GetFirstDayOccurrence(int year, YearDate day) =>
        new Date(_calendar, _calendar.IsLeapDay(day) ? GetLeap(year) : year, day);

    private int GetLeap(int year) =>
        _calendar.IsLeapYear(year) ? year : GetLeap(year + 1);

    public override string ToString() =>
        _day + "/" + _year;
}
