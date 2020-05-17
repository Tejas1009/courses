using System;

class GfG
{

    public static int findLCM(int a,
        int b)
    {
        int lar = Math.Max(a, b);
        int small = Math.Min(a, b);
        for (int i = lar; ; i += lar)
        {
            if (i % small == 0)
                return i;
        }
    }

    // Driver Code 
    public static void Main()
    {
        var data = Console.ReadLine();
        var inputData = data.Split(' ');
        Console.WriteLine(findLCM(int.Parse(inputData[0]), int.Parse(inputData[1])));

    }
}