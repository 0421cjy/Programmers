using System;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var count = Int32.Parse(input);

        for (int i = 0; i < count; i++)
        {
            var nums = Console.ReadLine().Split();
            var num1 = Int32.Parse(nums[0]);
            var num2 = Int32.Parse(nums[1]);

            Console.WriteLine($"Case #{i + 1}: {num1 + num2}");
        }
    }
}