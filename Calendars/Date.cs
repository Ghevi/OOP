using System;

namespace Calendars;

class Date
{
    private int _year;
    private YearDate _day;
    private Calendar _calendar;

    public Date(int year, YearDate day, Calendar calendar)
    {
        _year = year;
        _day = day;
        _calendar = calendar;
    }

    public Date AddYears(int count) =>
        FirstValidDate(_year + count, _day);

    private Date FirstValidDate(int year, YearDate day) =>
        day.IsLeap() && !IsLeap(year) ? new Date(year, day.GetNext(), _calendar)
        : new Date(year, day, _calendar);

    public Date GetFirstDayOccurrence(Date day) =>
        GetFirstDayOccurrence(_year, day._day);

    private bool IsLeap(int year) => _calendar.IsLeapYear(year);

    public Date GetFirstOccurrence(YearDate day) =>
        GetFirstDayOccurrence(day.IsBefore(_day) ? _year + 1 : _year, day);

    private Date GetFirstDayOccurrence(int year, YearDate day) =>
        new Date(day.IsLeap() ? GetLeap(year) : year, day, _calendar);

    private int GetLeap(int year) =>
        IsLeap(year) ? year : GetLeap(year + 1);

    public override string ToString() =>
        _day + "/" + _year;
}
