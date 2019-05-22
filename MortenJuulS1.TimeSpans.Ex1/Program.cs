using System;

namespace MortenJuulS1.TimeSpans.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //delOpg.1
            //TimeSpan aTimeSpan = new TimeSpan(2, 4, 30, 11);
            //TimeSpan aspitTimeSpan = new TimeSpan(6, 15, 0);
            //TimeSpan timeSinceIGotUp = new TimeSpan(2,30,0);

            ////delOpg.2
            //Console.WriteLine($"et tids rum: {aTimeSpan.ToString()}");
            //Console.WriteLine($"Skoledag på Aspit: {aspitTimeSpan.ToString()}");
            //Console.WriteLine($"Tiden siden jeg stod up: {timeSinceIGotUp.ToString()}");

            //delOpg.3
            TimeSpan spanOfTime1 = TimeSpan.Parse("00:39:02");
            TimeSpan spanOfTime2 = TimeSpan.Parse("18"); // you can use TimeSpan.Parse("18.00:00:00") also but it returns the same
            TimeSpan spanOfTime3 = TimeSpan.Parse("28.07:16:22");

            //delOpg.4
            Console.WriteLine(spanOfTime1.ToString());
            Console.WriteLine(spanOfTime2.ToString());
            Console.WriteLine(spanOfTime3.ToString());


        }
    }
}
