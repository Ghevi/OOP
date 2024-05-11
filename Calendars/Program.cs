using Calendars;
using System;

static void Report(Child child, SchoolSystem school)
{
    Console.WriteLine(
        child + " starts school on " + school.GetBeginning(child) +
        ", celebrates on " + child.GetFirstCelebrationAt(school));
}

Calendar calendar = new GregorianCalendar();

SchoolSystem school = new SchoolSystem(
    new YearDate(calendar, 3, 1),
    5,
    new YearDate(calendar, 8, 15));

Child jill = new Child(
    "Jill",
    new Date(calendar, 2016, new YearDate(calendar, 2, 29)));

Child jake = new Child(
    "Jake",
    new Date(calendar, 2015, new YearDate(calendar, 8, 27)));

Report(jill, school);
Report(jake, school);

Console.ReadLine();
