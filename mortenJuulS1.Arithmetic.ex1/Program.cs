using System;

namespace mortenJuulS1.Arithmetic.ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            //delOpg.1
            //c.i = 2
            var iResult = -5 * 2 + (-6 * -2);
            Console.WriteLine($"c.i:\t-5*2+(-6*-2) = {iResult}");
            //c.ii = -297
            var iiResult = 11 + (-20) + 36 * (-8);
            Console.WriteLine($"c.ii:\t11+(-20)+36*(-8) = {iiResult}");
            //c.iii = 8.641.976
            var iiiResult = -1234567 + 9876543;
            Console.WriteLine($"c.iii:\t-1234567 + 9876543 = {iiiResult}");
            //c.iv = 0
            var ivResult = 2 * (2 + 2 - 2 - 2) * 2 * 2;
            Console.WriteLine($"c.iv:\t2*(2+2-2-2)*2*2 = {ivResult}");
            //c.v = 0
            var vResult = 3.14 * 0;
            Console.WriteLine($"c.v:\t3,14 * 0 = {vResult}");
            //c.vi = -4,5‬
            var viResult = 2.7 - 7.2;
            Console.WriteLine($"c.vi:\t2,7 - 7,2 = {viResult}");
            //c.vii = 42,13‬
            var viiResult = 2.7 * 0.1 + (-3.14 + 6 * 7.5);
            Console.WriteLine($"c.vii:\t2.7 * 0.1 + (-3.14 + 6 * 7.5) = {viiResult}");

        }
    }
}
