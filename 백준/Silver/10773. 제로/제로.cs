using System;
using System.Collections.Generic;
using System.Linq;

public partial class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var count = Int32.Parse(input);

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < count; i++)
        {
            var input2 = Console.ReadLine();
            if (input2 == "0")
            {
                stack.Pop();
            }
            else
            {
                stack.Push(Int32.Parse(input2));
            }
        }

        Console.WriteLine(stack.Sum());
    }
}