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
            TestStack();
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
            
            Console.WriteLine("\t{0}\t{1}", sortedList.GetByIndex(sortedList.IndexOfKey("de eerste")), sortedList.GetByIndex(0));
            Console.WriteLine("\t{0}\t{1}", sortedList.GetByIndex(sortedList.IndexOfKey("de tweede")), sortedList.GetByIndex(1));
            Console.WriteLine("\t{0}\t{1}", sortedList.GetByIndex(sortedList.IndexOfKey("de derde")), sortedList.GetByIndex(2));
            Console.WriteLine("\t{0}\t{1}", sortedList.GetByIndex(sortedList.IndexOfKey("de vierde")), sortedList.GetByIndex(3));
            
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
    }
}