namespace Calendars;

class YearDate
{
    private int _month;
    private int _day;
    private Calendar _calendar;

    public YearDate(Calendar calendar, int month, int day)
    {
        _calendar = calendar;
        _month = month;
        _day = day;
    }

    public YearDate GetNext() =>
        IsEndOfMonth() ? new YearDate(_calendar, _calendar.NextMonth(_month), 1)
        : new YearDate(_calendar, _month, _day + 1);

    private bool IsEndOfMonth() =>
        _day == _calendar.DaysInMonth(_month);

    public bool IsBefore(YearDate other) =>
        _month < other._month || (_month == other._month && _day < other._day);

    public override string ToString() =>
        _month + "/" + _day;
}
