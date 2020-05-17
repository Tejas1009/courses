using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChange
{
    class Program
    {
        public static void CalcualateCoinChange(List<int> denoms, int n)
        {
            var counter = 0;
            for (int i = 0; i < denoms.Count; i++)
            {
                while (n >=0 && n >= denoms[i])
                {
                    n = n - denoms[i];
                    counter++;
                }
                if(n<=0)
                    break;
            }
            Console.WriteLine(counter);
            //Console.ReadLine();
        }

        static void Main(string[] args)
        {
            var denoms = new List<int> {10, 5, 1};
            int n = int.Parse(Console.ReadLine());
            CalcualateCoinChange(denoms,n);
        }
    }
}
