using System;

namespace MortenJuulS1.MethodsCont.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private static void PrintArray(string[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }

        private static void PrintArray(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }

        private static void PrintArray(int[] myArray, char myChar)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
                Console.WriteLine(myChar);
            }
        }

        private static int CalculateSum(int[] myArray)
        {
            int sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sum = sum + myArray[i];
            }
            return sum;
        }

        private static double CalculateSum(double[] myArray)
        {
            double sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sum = sum + myArray[i];
            }
            return sum;
        }

        private static int CalculateAvg(int[] myArray)
        {
            int sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sum = sum + myArray[i];
            }
            return sum / myArray.Length;
        }

        private static double CalculateAvg(double[] myArray)
        {
            double sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sum = sum + myArray[i];
            }
            return sum / myArray.Length;
        }

        private static int ReadUntilInt(string myString)
        {
            while (true)
            {
                Console.WriteLine(myString);
                string aString = Console.ReadLine();

                if (int.TryParse(aString, out int myInt))
                {
                    return myInt;
                }
            }
        }

        private static double ReadUntilDouble(string myString)
        {
            while (true)
            {
                Console.WriteLine(myString);
                string aString = Console.ReadLine();

                if (double.TryParse(aString, out double myDouble))
                {
                    return myDouble;
                }
            }
        }

    }
}
