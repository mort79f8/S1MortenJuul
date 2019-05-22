using System;

namespace MortenJuulS1.DateAndTime.Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //delOpg.1
            //Console.WriteLine("Indtaste et årstal:");
            //int aYear = int.Parse(Console.ReadLine());
            //while (true)
            //{

            //    if (DateTime.IsLeapYear(aYear))
            //    {
            //        Console.WriteLine($"{aYear} er det næste skudår");
            //        break;
            //    }
            //    else
            //    {
            //        aYear++;
            //    }
            //}

            //delOpg.2
            //DateTime variableToWorkWith = new DateTime(2018, 11, 26,0,17,50);
            //Console.WriteLine(variableToWorkWith.ToString("dd-MM-yyyy"));
            //Console.WriteLine(variableToWorkWith.ToString("dd" + ". " + "MMMM yyyy"));
            //Console.WriteLine(variableToWorkWith.ToString("dd" + ". " + "MMMM yyyy HH:mm:ss"));
            //Console.WriteLine(variableToWorkWith.ToString("dd" + ". " + "dddd MMM yy" ));

            //delOpg.3
            string birthYearString;

            while (true)
            {

                Console.WriteLine("indtast hvornår du blev født: (f.eks: 21-08-1976)");
                birthYearString = Console.ReadLine();
                DateTime isPropperFormat;
                if (DateTime.TryParse(birthYearString, out isPropperFormat))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Det var ikke det rigtige format prøv igen");
                }
            }
            DateTime birthYear = DateTime.Parse(birthYearString);
            int age = DateTime.Now.Year - birthYear.Year;
            if (DateTime.Now.DayOfYear < birthYear.DayOfYear)
            {
                age = age - 1;
            }
            Console.WriteLine($"Du er {age} år gamle lad os se om du må: Købe øl, få kørekort eller købe spiritus");
            bool canBuyBeer = false;
            bool canGetDrivningLicence = false;
            bool canBuyAlcohol = false;

            if (age < 16)
            {
                Console.WriteLine("Du er ikke gamle nok til at få nået!");
            }
            else if (age > 18)
            {
                Console.WriteLine("Du er gamle nok til det hele!");
            }

            switch (age)
            {
                case 16:
                    canBuyBeer = true;
                    break;
                case 17:
                    canGetDrivningLicence = true;
                    break;
                case 18:
                    canBuyAlcohol = true;
                    break;
                default:

                    break;
            }

            if (canBuyBeer)
            {
                Console.WriteLine("Du må gerne købe øl");
            }
            if (canGetDrivningLicence)
            {
                Console.WriteLine("Du må gerne få et kørekort og købe øl");
            }
            if (canBuyAlcohol)
            {
                Console.WriteLine("Du må gerne købe spiritus, få et kørekort og købe øl");
            }

        }

    }
}
