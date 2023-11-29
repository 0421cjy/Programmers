using System;

namespace backjun
{
    public class Program
    {
        static void Main(string[] args)
        {
            var totalCount = Console.ReadLine();
            var list = Console.ReadLine().Split(" ").ToList();
            int count = 0;

            foreach(var s in list)
            {
                if (IsPrime(Int32.Parse(s)))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }

        static bool IsPrime(int n)
        {
            if (n == 1) return false;
            
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}