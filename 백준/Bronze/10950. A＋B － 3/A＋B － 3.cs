using System;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var count = Int32.Parse(input);

        for (int i = 0; i < count; i++)
        {
            var input_numbers = Console.ReadLine().Split();
            var num1 = Int32.Parse(input_numbers[0]);
            var num2 = Int32.Parse(input_numbers[1]);

            Console.WriteLine(num1 + num2);
        }
    }
}