using System;

namespace MortenJuulS1.DataAndTime.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //delOpg.1
            DateTime myBirthday = new DateTime(1976, 08, 21);
            DateTime queenMargrethe = new DateTime(1940, 04, 16);
            DateTime constitutionSigned = new DateTime(1849, 06, 5);
            DateTime firstGameHandballMen = new DateTime(2019,01,14, 20, 15, 00);
            DateTime christmasAspitEnding = new DateTime(2019,12,20);

            //delOpg.2
            Console.WriteLine($"Min fødselsdag: {myBirthday.ToLongDateString()}");
            Console.WriteLine($"Droning Margrethes fødselsdag: {queenMargrethe.ToShortDateString()}");
            Console.WriteLine($"Grundlov underskrevet: {constitutionSigned.ToShortDateString()}");
            Console.WriteLine($"Herrens første kamp i håndbold: {firstGameHandballMen.ToString()}");
            Console.WriteLine($"Aspit juleafslutning: {christmasAspitEnding.ToShortDateString()}");
            Console.WriteLine();

            //delOpg.3+4
            DateTime currentTime = DateTime.Now;
            Console.WriteLine($"Dato og klokkeslægt lige nu: {currentTime.ToShortTimeString()}");
            DateTime socialActivitesFriday = new DateTime(2019, 05, 10, 12, 30, 00);
            DateTime gotToWorkTime = new DateTime(2019, 05, 16, 07, 45, 00);
            DateTime newsDR1Saturday = new DateTime(2019, 05, 18, 18, 30, 00);
            currentTime = DateTime.Now;
            Console.WriteLine($"Social aktiviteter i fredags started: {socialActivitesFriday.ToShortTimeString()}");
            Console.WriteLine($"Jeg mødte: {gotToWorkTime.ToString()}");
            Console.WriteLine($"Tv-Avisen vises sidste gang lørdag: {newsDR1Saturday.ToLongTimeString()}");
            Console.WriteLine($"Dato og klokkeslægt lige nu: {currentTime.ToShortTimeString()}");
            


        }
    }
}
