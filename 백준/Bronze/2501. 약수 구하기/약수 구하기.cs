using System;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();
        var num1 = Int32.Parse(input[0]);
        var num2 = Int32.Parse(input[1]);

        Console.WriteLine(divisor(num1, num2));
    }

    static int divisor(int n, int idx)
    {
        int index = 0;

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                index++;
                
                if (index == idx)
                {
                    return i;
                }
            }
        }

        return 0;
    }
}