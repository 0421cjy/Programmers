using System;
using System.Collections.Generic;

public partial class Program
{
    static void Main(string[] args)
    {
        Stack<double> stack = new Stack<double>();

        var input = Console.ReadLine();
        var count = Int32.Parse(input);

        int[] array = new int[count];

        var input2 = Console.ReadLine();

        for (int i = 0; i < count; i++) 
        {
            array[i] = Int32.Parse(Console.ReadLine());
        }

        foreach (var s in input2)
        {
            switch (s)
            {
                case '+':
                    {
                        var a = stack.Pop();
                        var b = stack.Pop();
                        stack.Push(b + a);
                        break;
                    }
                case '-':
                    {
                        var a = stack.Pop();
                        var b = stack.Pop();
                        stack.Push(b - a);
                        break;
                    }
                case '*':
                    {
                        var a = stack.Pop();
                        var b = stack.Pop();
                        stack.Push(b * a);
                        break;
                    }
                case '/':
                    {
                        var a = stack.Pop();
                        var b = stack.Pop();
                        stack.Push(b / a);
                        break;
                    }
                default:
                    {
                        stack.Push(array[s - 'A']);
                        break;
                    }
            }
        }

        Console.WriteLine(string.Format("{0:0.00}", stack.Pop()));
    }
}