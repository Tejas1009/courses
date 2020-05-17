using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fib
{
    class Program
    {
        public static ulong FibonacciNumber(ulong num)
        {
            if(num <= 1)
                return num;

            int[] arr = new int[num + 2];
            arr[0] = 0;
            arr[1] = 1;

            for (ulong i = 2; i <= num; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            return (ulong) arr[num];
        }
        static void Main(string[] args)
        {
            var inputNumber = Console.ReadLine();
            var res = FibonacciNumber(ulong.Parse(inputNumber));
            Console.Write(res);
            //Console.ReadLine();
        }
    }
}
