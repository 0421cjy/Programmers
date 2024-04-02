using System;
using System.Linq;

public partial class Program
{
    static void Main(string[] args)
    {
        var bools = Enumerable.Repeat(true, 1000000 + 1).ToArray();
        var ints = new int[1000000 + 1];

        IsPrime(bools, ints, 1000000);

        var input = Console.ReadLine();
        var count = Int32.Parse(input);

        for (int i = 0; i < count; i++) 
        {
            var number = Console.ReadLine();
            var n = Int32.Parse(number);

            Console.WriteLine(GetGoldbachPartition(bools, ints, n));
        }
    }

    static int GetGoldbachPartition(bool[] bools, int[] ints, int n)
    {
        int count = 0;

        for (int i = 2; i <= n / 2; i++)
        {
            if (bools[i] && bools[n - i])
            {
                count++;
            }
        }

        return count;
    }

    static void IsPrime(bool[] bools, int[] ints, int n)
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