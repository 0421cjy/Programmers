using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();
        var num1 = Int32.Parse(input[0]);
        var num2 = Int32.Parse(input[1]);

        var result = divisor(num1).Where((x, idx) => idx == num2 - 1);

        if (result.Count() == 0) 
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine(result.First());
        }
    }

    static IEnumerable<int> divisor(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                yield return i;
            }
        }
    }
}