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

            int a = 0;
            int b = 0;

            for (int i = 0; i <= number / 2; i++)
            {
                a = primeArray[i];
                b = number - a;

                if (isPrime[a] && isPrime[b])
                {
                    sb.AppendLine($"{number} = {a} + {b}");
                    break;
                }
            }
        }

        Console.WriteLine(sb.ToString());
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