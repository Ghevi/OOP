namespace Calendars;

class GregorianCalendar : Calendar
{
    public override bool IsLeapYear(int year)
        => year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

    public override bool IsLeapDay(int month, int day)
        => month == 2 && day == 29;

    public override int DaysInMonth(int month)
        => month == 2 ? 29 
            : month == 4 || month == 6 || month == 9 || month == 11 ? 30
            : 31;

    public override int NextMonth(int month)
        => month % 12 + 1;
}