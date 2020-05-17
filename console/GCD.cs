using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fib
{
    class Program
    {
        public static long GCDNumber(long firstNum, long secondNum)
        {
            if (secondNum <= 0)
            {
                return firstNum;
            }

            return GCDNumber(secondNum, firstNum % secondNum);
        }

        static void Main(string[] args)
        {
            var data = Console.ReadLine();
            var inputData = data.Split(' ');

            var res = GCDNumber(long.Parse(inputData[0]), long.Parse(inputData[1]));
            Console.Write(res);
            Console.ReadLine();
        }
    }
}
