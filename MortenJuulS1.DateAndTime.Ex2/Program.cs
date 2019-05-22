using System;

namespace MortenJuulS1.DateAndTime.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //delOpg.1
            DateTime timeNow = DateTime.Now;
            DateTime timeToday = DateTime.Today;
            DateTime timeUtcNow = DateTime.UtcNow;

            Console.WriteLine($"Klokken nu: {timeNow.ToString()}");
            Console.WriteLine($"Idag: {timeToday.ToString()}");
            Console.WriteLine($"Utc tidszone lige nu: {timeUtcNow.ToString()}");
            Console.WriteLine();

            //delOpg.2
            DateTime rightNow = DateTime.Now;
            DateTime addedAYear = rightNow.AddYears(1);
            Console.WriteLine($"dato lige nu + 1 år: {addedAYear.ToString()}");
            DateTime subtractTwoYears = rightNow.AddYears(-2);
            Console.WriteLine($"dato lige nu -2 år: {subtractTwoYears.ToString()}");
            DateTime addedThirdyDays = rightNow.AddDays(30);
            Console.WriteLine($"dato lige nu + 30 dage: {addedThirdyDays}");
            DateTime addedTwentyThreeHours = rightNow.AddHours(23);
            Console.WriteLine($"dato lige nu + 23 timer: {addedTwentyThreeHours}");
            DateTime addedHours = rightNow.AddHours(23);
            DateTime addedHoursAndMin = addedHours.AddMinutes(17);
            Console.WriteLine($"dato lige nu + 23 timer og 17 min.: {addedHoursAndMin}");
            Console.WriteLine();

            //delOpg.3
            DateTime withTime = DateTime.Now;
            DateTime noTime = new DateTime(withTime.Year, withTime.Month, withTime.Day);

            Console.WriteLine($"variable med tid: {withTime.ToString()}");
            Console.WriteLine($"variable uden tid: {noTime.ToString("MMMM dd, yyyy")}");

            //delOpg.4
            Console.WriteLine($"2019 er et skudår: {DateTime.IsLeapYear(2019)}");

        }
    }
}
