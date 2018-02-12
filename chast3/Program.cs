using System;
using System.Collections;
using System.Collections.Generic;

namespace chast3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
//            TestArrayList();
//            TestSortedList();
//            TestStack();
            UsingDictionary();
        }

        private static void TestArrayList()
        {
            ArrayList arrayList = new ArrayList();
            
            arrayList.Add("How");
            arrayList.Add("are");
            arrayList.Add("you");
            arrayList.Add("?");

            foreach (IEnumerable instance in arrayList)
            {
                Console.WriteLine(instance);
            }
        }

        private static void TestSortedList()
        {
            SortedList sortedList = new SortedList
            {
                {"de eerste", "How"},
                {"de tweede", "are"},
                {"de derde", "you"},
                {"de vierde", "?"}
            };
            

            Console.WriteLine("by key\tby index");
            
            Console.WriteLine("{0}\t{1}", sortedList["de eerste"], sortedList.GetByIndex(0));
            Console.WriteLine("{0}\t{1}", sortedList["de tweede"], sortedList.GetByIndex(1));
            Console.WriteLine("{0}\t{1}", sortedList["de derde"], sortedList.GetByIndex(2));
            Console.WriteLine("{0}\t{1}", sortedList["de vierde"], sortedList.GetByIndex(3));
            
        }

        private static void TestStack()
        {
            Stack stack = new Stack();
            
            stack.Push("Hi");
            stack.Push("there");
            stack.Push("!");

            foreach (IEnumerable instance in stack)
            {
                Console.WriteLine(instance);
            }
            
            Console.WriteLine("peek: {0}", stack.Peek());
        }

        private static void UsingDictionary()
        {
            Dictionary<string, int> numbers = new Dictionary<string, int>();
            bool correctInput = false;
            int value = -1;

            for (int i = 0; i < 10; ++i)
            {
                numbers.Add(i.ToString(), i);
            }

            while (!correctInput)
            {
                Console.WriteLine("Enter your number, plese: ");
                correctInput = numbers.TryGetValue(Console.ReadLine(), out value);
                
            }
            
            Console.WriteLine("your value: {0}", value);
            
        }
    }
}