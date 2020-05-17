using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChange
{
    class Program
    {
        public static void CalculateNumberOfFuelStops(int totalKm,int capacity, int[] arr,int n)
        {
            int currentRefill = 0, numRefill = 0, lastRefill = 0;
            while (currentRefill <= n)
            {
                lastRefill = currentRefill;
                while (currentRefill <= n && arr[currentRefill+1] - arr[lastRefill] <= capacity)
                {
                    currentRefill++;
                }

                if (currentRefill == lastRefill)
                {
                    Console.WriteLine("-1");
                    break;
                }

                if (currentRefill <= n)
                {
                    numRefill++;
                }
            }

            if (currentRefill != lastRefill)
            {
                Console.WriteLine(numRefill);
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            var totalKm = int.Parse(Console.ReadLine());
            
            var fuelTank = int.Parse(Console.ReadLine());

            var petrolPumpInterval = int.Parse(Console.ReadLine());
            var data = Console.ReadLine();
            var inputData = data.Split(' ');
            int[] arr = new int[petrolPumpInterval + 2];
            arr[0] = 0;
            for (int i = 1; i < petrolPumpInterval+1; i++)
            {
                arr[i] = int.Parse(inputData[i-1]);
            }
            arr[petrolPumpInterval + 1] = totalKm;
            CalculateNumberOfFuelStops(totalKm, fuelTank, arr, petrolPumpInterval);
        }
    }
}
