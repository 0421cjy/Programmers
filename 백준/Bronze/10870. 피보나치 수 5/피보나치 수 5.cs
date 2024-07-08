using System;

public partial class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var index = Int32.Parse(input);

        Console.WriteLine(FibonachiNumber(index));
    }

    static int FibonachiNumber(int number)
    {
        if (number == 0) return 0;
        if (number == 1) return 1;

        return FibonachiNumber(number - 2) + FibonachiNumber(number - 1);
    }
}