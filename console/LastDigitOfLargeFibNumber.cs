using System;
using System.Numerics;
					
public class Program
{
	public static void Main()
	{
		//Console.WriteLine("Hello World");
		var data = Console.ReadLine();
        var inputData = data.Split(' ');

		FibonacciNumber(ulong.Parse(inputData[0]),10);	
	}
	
	public static void FibonacciNumber(ulong num, ulong m)
        {
            if(num <= 1)
                Console.WriteLine(num);

            int[] arr = new int[num + 2];
            //arr[0] = 0;
            //arr[1] = 1;
		
			BigInteger a = 0, b = 1, c = 0;  

            for (ulong i = 2; i <= num; i++)
            {
				c = a + b;  
                a = b;  
                b = c;
				//arr[i] = BigInteger.Add(arr[i - 1],arr[i - 2]);
                //arr[i] = arr[i - 1] + arr[i - 2];
            }

            Console.WriteLine(b % m);
        }
}