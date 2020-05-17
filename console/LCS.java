using System;

class GFG
{
    static int lcs(char[] X, char[] Y, int m, int n)
    {
        int[,] L = new int[m + 1, n + 1];
        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                if (i == 0 || j == 0)
                    L[i, j] = 0;
                else if (X[i - 1] == Y[j - 1])
                    L[i, j] = L[i - 1, j - 1] + 1;
                else
                    L[i, j] = max(L[i - 1, j], L[i, j - 1]);
            }
        }
        return L[m, n];
    }

    static int max(int a, int b)
    {
        return (a > b) ? a : b;
    }

    public static void Main()
    {
        var n1 = Console.ReadLine();
        String s1 = Console.ReadLine();
        var n2 = Console.ReadLine();
        String s2 = Console.ReadLine();

        var str1 = s1.Replace(" ", "");
        var str2 = s2.Replace(" ", "");

        char[] X = str1.Substring(str1.Length-int.Parse(n1)).ToCharArray();
        char[] Y = str2.Substring(str2.Length-int.Parse(n2)).ToCharArray();
        int m = X.Length;
        int n = Y.Length;

        Console.Write(lcs(X, Y, m, n));
    }
}
