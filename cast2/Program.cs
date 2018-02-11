using System;
using System.Net;
using System.Runtime.Remoting.Services;

namespace cast2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
//            TwoDarrayTest();
//            CloneArray();
//            StringArrays();
            TestParams();
        }

        private static void TwoDarrayTest()
        {
            int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            
            Console.WriteLine("Values of array elements:");
            for (int outer = array2D.GetLowerBound(0); outer <= array2D.GetUpperBound(0);
                outer++)
            for (int inner = array2D.GetLowerBound(1); inner <= array2D.GetUpperBound(1);
                inner++)
                Console.WriteLine("      {3}{0}, {1}{4} = {2}", outer, inner,
                    array2D.GetValue(outer, inner), "{", "}");
            
            Console.WriteLine("Dimensions of array:");
            Console.WriteLine(array2D.Rank);
            
            Console.WriteLine("Length of array:");
            Console.WriteLine(array2D.Length);
            
        }

        private static int EnterInt()
        {
            bool correctEnter = false;
            int number = 0;

            while (!correctEnter)
            {
                try
                {
                    number = Int32.Parse(Console.ReadLine());
                    correctEnter = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Incorrect data. Re-enter, please");
                }
            }
            
            return number;
        }
        

        private static int[] EnterArray()
        {
            int[] array = null;
            int n;

            Console.WriteLine("Enter dimension of the array: ");
            n = EnterInt();
            array = new int[n];

            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine("Enter {0} element of the array: ", i + 1);
                array[i] = EnterInt();
            }
            
            return array;
        }

        private static void CloneArray()
        {
            int[] array = (int[])EnterArray().Clone();

            foreach (int t in array)
            {
                Console.WriteLine(t);
            }
        }

        private static void StringArrays()
        {
            string[] array = new string[3];

            for (int i = 0; i < array.Length; ++i)
            {
                Console.WriteLine("Enter a string: ");
                array[i] = Console.ReadLine();
            }
            
            Array.Sort(array);
            
            Console.WriteLine("Result array: ");
            foreach (string t in array)
            {
                Console.WriteLine(t);
            }
        }

        private static void TestParams()
        {
            int[] array = EnterArray();
            long sum = 0;

            foreach (int t in array)
            {
                sum += t;
            }
            
            Console.WriteLine("Sum of the array: {0}", sum);
        }
        
        
    }
}