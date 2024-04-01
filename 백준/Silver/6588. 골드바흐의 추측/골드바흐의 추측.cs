using System;
using System.Linq;
using System.Text;

public partial class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        var isPrime = Enumerable.Repeat(true, 1000001).ToArray();
        var primeArray = new int[1000001];

        GetPrimeNumberList(isPrime, primeArray, 1000000);

        while (true) 
        {
            var input = Console.ReadLine();
            var number = Int32.Parse(input);

            if (number == 0) break;
            
            var results = GetGoldbachConjecture(isPrime, primeArray, number);
            if (results == (0, 0))
            {
                sb.AppendLine("Goldbach's conjecture is wrong.");
            }
            else
            {
                sb.AppendLine($"{number} = {results.Item1} + {results.Item2}");
            }
        }

        Console.WriteLine(sb.ToString());
    }

    public static (int, int) GetGoldbachConjecture(bool[] bools, int[] ints, int n)
    {
        int a = 0;
        int b = 0;

        for (int i = 0; i <= n / 2; i++)
        {
            a = ints[i];
            b = n - a;

            if (bools[a] && bools[b])
            {
                return (a, b);
            }
        }

        return (0, 0);
    }

    public static void GetPrimeNumberList(bool[] bools, int[] ints, int n)
    {
        int index = 0;

        for (int i = 2; i * i <= n; i++)
        {
            if (bools[i])
            {
                ints[index++] = i;

                for (int j = i * i; j <= n; j += i)
                {
                    bools[j] = false;
                }
            }
        }
    }
}