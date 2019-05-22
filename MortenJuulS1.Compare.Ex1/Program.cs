using System;

namespace MortenJuulS1.Compare.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //delOpg.1.b
            //b.i
            bool iCompare = 17 < 10;
            Console.WriteLine($"b.i:\t17 < 10 {iCompare}");
            //b.ii
            bool iiCompare = 20 > 20;
            Console.WriteLine($"b.i:\t20 > 20 {iiCompare}");
            //b.iii
            bool iiiCompare = 20 <= 20 ;
            Console.WriteLine($"b.i:\t20 <= 20 {iiiCompare}");
            //b.iv
            bool ivCompare = 50 != 10*5;
            Console.WriteLine($"b.i:\t50 != 10 * 5 {ivCompare}");
            //b.v
            bool vCompare = 17 - 0.15 >= 28 - 1.15;
            Console.WriteLine($"b.i:\t17 - 0.15 >= 28 - 1.15 {vCompare}");
            //b.vi
            bool viCompare = 5 * 3 == 15;
            Console.WriteLine($"b.i:\t5 * 3 == 15 {viCompare}");
            //b.vii
            bool viiCompare = 5/5 == 1;
            Console.WriteLine($"b.i:\t5/5 == 1 {viiCompare}");





        }
    }
}
