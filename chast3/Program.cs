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
//            TestSortedList();
//            TestStack();
//            UsingDictionary();
//            SeparateWords();
        }

        private static void TestArrayList()
        {
            ArrayList arrayList = new ArrayList();
            
            arrayList.Add("How");
            arrayList.Add("are");
            arrayList.Add("you");
            arrayList.Add("?");

            IEnumerator instance = arrayList.GetEnumerator();
            while(instance.MoveNext())
            {
                Console.WriteLine(instance.Current);
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

        private static void SeparateWords()
        {
            int s = 0;
            string[] words;
            string[] result = {"Noting"};

            while (3 != s)
            {
                Console.WriteLine("Enter phrase, please: ");
                words = Console.ReadLine().Split(' ');

                Console.WriteLine("Choose comparator:\n1.By alphabet\n2.By length\n3.Exit");


                switch (s = EnterInt())
                {
                    case 1:
                        result = SortByAlphabet(words);
                        break;
                    case 2:
                        result = SortByLength(words);
                        break;
                    default:
                        Console.WriteLine("Unsupported operation");
                        return;
                }
                Console.WriteLine("Sorted array: ");
                DisplayArray(result);
            }

        }

        private static string[] SortByAlphabet(string[] array)
        {
            string[] result = DuplicateArray(array);

            Array.Sort(result);
            
            return result;
        }

        private static string[] SortByLength(string[] array)
        {
            string[] result = DuplicateArray(array);

            Array.Sort(result, (x,y) => x.Length.CompareTo(y.Length));
            
            return result;
        }

        private static T[] DuplicateArray<T>(T[] array)
        {
            T[] duplicatedArray = new T[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                duplicatedArray[i] = array[i];
            }

            return duplicatedArray;
        }
        
        private static void DisplayArray<T>(T[] array)
        {
         
            foreach (T instace in array)
            {
                Console.WriteLine(instace);
            }

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
    }
}