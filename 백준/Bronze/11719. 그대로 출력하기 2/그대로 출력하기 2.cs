using System;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            var input = Console.ReadLine();
            if (input == null) break;

            Console.WriteLine(input);
        }
    }
}