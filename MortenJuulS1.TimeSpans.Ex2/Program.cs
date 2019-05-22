using System;

namespace MortenJuulS1.TimeSpans.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //delOpg.1
            DateTime chrismasEvening = DateTime.Parse("24-12-2019 18:00");
            TimeSpan timeToChrismas = (chrismasEvening - DateTime.Now) ;
            Console.WriteLine("1.a: tid til juleaften: {0:dd\\:hh\\:mm\\:ss}", timeToChrismas);

            DateTime nextYear = DateTime.Parse("01-01-2020 00:01");
            TimeSpan timeToNewYear = nextYear - DateTime.Now;
            Console.WriteLine("1.b: tid til det nye år: {0:dd\\:hh\\:mm\\:ss}", timeToNewYear);

            DateTime birth = DateTime.Parse("21-08-1976");
            TimeSpan timeSinceBirth = DateTime.Now - birth;
            Console.WriteLine("1.c: tid siden jeg var født: {0:dd\\:hh\\:mm\\:ss}", timeSinceBirth);
            
            DateTime crowning = DateTime.Parse("14-01-1972");
            TimeSpan timeSinceCrowning = DateTime.Now - crowning;
            Console.WriteLine("1.d: tid siden Margrethe blev kronet: {0:dd\\:hh\\:mm\\:ss}", timeSinceCrowning);

            DateTime newsSaturday = DateTime.Parse("18-05-2019 18:30");
            TimeSpan timeToNews = newsSaturday - DateTime.Now;
            Console.WriteLine("1.c: tid til Tv Avisen på lørdag: {0:dd\\:hh\\:mm\\:ss}", timeToNews );

            //delOpg.2
            Console.WriteLine("Du skal nu indtaste 2 tidspunkter og vi vil finde hvor lang tid der er imellem dem (format: dage:time:min:sec)");
            Console.WriteLine("Det første tidspunkt: ");
            TimeSpan firstTime = TimeSpan.Parse(Console.ReadLine());
            Console.WriteLine("Det andet tidspunkt: ");
            TimeSpan secondTime = TimeSpan.Parse(Console.ReadLine());

            TimeSpan difference = firstTime - secondTime;
            if (difference < TimeSpan.Parse("0"))
            {
                difference = difference * -1;
            }

            Console.WriteLine($"Tiden imellem de to tidspunker er: {difference}");

        }
    }
}
