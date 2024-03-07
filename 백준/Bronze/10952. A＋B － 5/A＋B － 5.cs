using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            var input = Console.ReadLine().Split();

            var num1 = Int32.Parse(input[0]);
            var num2 = Int32.Parse(input[1]);

            if (num1 + num2 == 0) break;

            Console.WriteLine(num1 + num2);
        }
    }
}