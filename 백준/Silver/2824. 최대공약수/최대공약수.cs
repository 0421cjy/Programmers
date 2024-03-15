using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        var count1 = Console.ReadLine();

        var input1 = Console.ReadLine().Split();
        var num1 = new BigInteger(1);

        for (int i = 0; i < input1.Length; i++) 
        {
            num1 *= BigInteger.Parse(input1[i]);
        }

        Console.ReadLine();

        var input2 = Console.ReadLine().Split();
        var num2 = new BigInteger(1);

        for (int i = 0; i < input2.Length; i++)
        {
            num2 *= BigInteger.Parse(input2[i]);
        }

        var result = gcd(num1, num2).ToString();
        if (9 < result.Length)
        {
            Console.WriteLine(result.Substring(result.Length - 9));
        }
        else
        {
            Console.WriteLine(result);
        }
    }

    static BigInteger gcd(BigInteger n, BigInteger m)
    {
        while(0 < m)
        {
            var r = n % m;
            n = m;
            m = r;
        }

        return n;
    }
}