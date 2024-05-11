using System;

namespace Calendars
{
    class Program
    {
        static void Report(Child child, SchoolSystem school)
        {
            Console.WriteLine(
                child + " starts school on " + school.GetBeginning(child) +
                ", celebrates on " + child.GetFirstCelebrationAt(school));
        }

        static void Main(string[] args)
        {
            Calendar calendar = new GregorianCalendar();

            SchoolSystem school = new SchoolSystem(
                new YearDate(3, 1, calendar),
                5, 
                new YearDate(8, 15, calendar));

            Child jill = new Child(
                "Jill", 
                new Date(2016, new YearDate(2, 29, calendar), 
                calendar));
            Child jake = new Child(
                "Jake", 
                new Date(2015, new YearDate(8, 27, calendar),
                calendar));

            Report(jill, school);
            Report(jake, school);

            Console.ReadLine();
        } 
    }
}