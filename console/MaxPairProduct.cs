using System;
using System.Collections.Generic;
using System.Linq;

namespace APlusB
{
    class Program
    {
        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public static long maxProduct(List<long> arr, long n)
        {
            // Initialize max product pair 
            long a = arr[0], b = arr[1];

            // Traverse through every possible pair 
            // and keep track of max product 
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (arr[i] * arr[j] > a * b)
                    {
                        a = arr[i];
                        b = arr[j];
                    }

            return a * b;
        } 

        public static long GetMaxPairProduct(long numberOfElements, List<long> inputArray)
        {
            var firstIndex = -1;
            var secondIndex = -1;

            for (var i=0;i<numberOfElements;i++)
            {
                if (firstIndex == -1 || inputArray[i] > inputArray[firstIndex])
                {
                    firstIndex = i;
                }
            }

            for (var i=0;i<numberOfElements;i++)
            {
                if ((firstIndex!=i && secondIndex == -1) || (firstIndex!=i && inputArray[i] <= inputArray[firstIndex] && inputArray[i] > inputArray[secondIndex]))
                {
                    secondIndex = i;
                }
            }

            return inputArray[firstIndex] * inputArray[secondIndex];
            //Console.WriteLine(inputArray[firstIndex] * inputArray[secondIndex]);
            //Thread.Sleep(2000);
        }

        static void Main(string[] args)
        {

            //while (true)
            //{
            //    long n = RandomNumber(50, 80);
            //    var a = new List<long>();
            //    for (var i = 0; i < n; i++)
            //    {
            //        var num = RandomNumber(0,i*78786);
            //        a.Add(num);
            //    }

            //    var res1 = maxProduct(a, n);
            //    var res2 = GetMaxPairProduct(n, a);
            //    if (res1 != res2)
            //    {
            //        Console.WriteLine("Not equal");
            //        Console.WriteLine("First res: " + res1,"Second res: "+ res2);
            //        Console.ReadLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Matched");
            //        Console.WriteLine("First res: " + res1, "Second res: " + res2);
            //    }
            //}

            var numberOfElements = long.Parse(Console.ReadLine());

            var data = Console.ReadLine();
            var inputData = data.Split(' ');

            var inputArray = inputData.Select(long.Parse).ToList();
            var res = GetMaxPairProduct(numberOfElements, inputArray);
            Console.WriteLine(res);
            return;
        }
    }
}
