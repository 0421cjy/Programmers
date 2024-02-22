using System;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var value1 = Int32.Parse(input);

        for (int i = 2; i <= value1; i++)
        {
            while (value1 % i == 0)
            {
                value1 = value1 / i;
                Console.WriteLine(i);
            }

            if (value1 <= 1)
            {
                break;
            }
        }
    }
}