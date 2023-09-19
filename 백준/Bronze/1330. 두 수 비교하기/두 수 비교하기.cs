using System;

public class Program
{
    static void Main(string[] args)
    {
        var list = Console.ReadLine().Split();

        int a = Int32.Parse(list[0]);
        int b = Int32.Parse(list[1]);

        if (a > b)
        {
            Console.WriteLine(">");
            return;
        }
        else if (a < b)
        {
            Console.WriteLine("<");
            return;
        }
        else
        {
            Console.WriteLine("==");
        }
    }
}
