using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            var input = Console.ReadLine();
            if (input == null) break;

            var input_nums = input.Split();

            var num1 = Int32.Parse(input_nums[0]);
            var num2 = Int32.Parse(input_nums[1]);

            Console.WriteLine(num1 + num2);
        }
    }
}