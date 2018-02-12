using System;
using System.Collections;
using System.Collections.Generic;

namespace chast3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TestArrayList();
        }

        private static void TestArrayList()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Hello");
            arrayList.Add("World");
            arrayList.Add("!");

            foreach (IEnumerable instance in arrayList)
            {
                Console.WriteLine(instance);
            }
        }

        private static void TestSortedList()
        {
            
        }
    }
}