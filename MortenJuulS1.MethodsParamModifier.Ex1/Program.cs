using System;
using System.Linq;

namespace MortenJuulS1.MethodsParamModifier.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalcSum(3, 4, 5, 67, 1, 3)); ;
            Console.WriteLine(Concatenate('m','o','r','t','e','n'));
            Console.WriteLine(Concatenate("Morten", "går", "på", "Aspit"));
            PrintWelcome("da");
            PrintWelcome("eng");
            PrintWelcome("jp");
            PrintWelcome("de");
            PrintWelcome("in");
            string myString = "hej MED DIG";
            SetFirstCharToUpper(ref myString);
            Console.WriteLine(myString);
            double myVat = 10;
            AddVat(ref myVat);
            Console.WriteLine(myVat);
            int[] myArray = new int[] { 0, 2, 3, 4, 0, 1, 0, 4, 0, 6, 0, 0, 6,0,0 };
            ContrainsZeros(myArray,out int zeroes);
            Console.WriteLine(zeroes);

        }

        private static int CalcSum(params int[] values)
        {
            int result = 0;
            foreach (var item in values)
            {
                result += item;
            }
            return result;
        }

        private static string Concatenate(params char[] values)
        {
            string result = "";
            foreach (var item in values)
            {
                result += item;
            }
            return result;
        }

        private static string Concatenate(params string[] values)
        {
            string result = string.Join(" ", values);
            return result;
        }

        private static void PrintWelcome (string value="da")
        {
            switch (value)
            {
                case "da":
                    Console.WriteLine("Hej verden!");
                    break;
                case "eng":
                    Console.WriteLine("Hello World!");
                    break;
                case "jp":
                    Console.WriteLine("Kon'nichiwa sekai");
                    break;
                case "de":
                    Console.WriteLine("Hallo Welt");
                    break;
                case "in":
                    Console.WriteLine("Namaste duniya");
                    break;
                default:
                    break;
            }
        }

        private static void SetFirstCharToUpper(ref string value)
        {
            value = char.ToUpper(value[0]) + value.Substring(1).ToLower();
        }

        private static void AddVat(ref double value, double vat = 0.25)
        {
            value = value * (1 + vat);
        }

        private static bool ContrainsZeros(int[] arg1, out int returnAmountOfZeroes)
        {
            int[] matchedValue = Array.FindAll(arg1, x => x == 0);
            returnAmountOfZeroes = matchedValue.Length;
            return arg1.Contains(0);
        }
    }
}
