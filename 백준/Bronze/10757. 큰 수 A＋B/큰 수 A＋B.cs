using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();

        BigNumerAdd(input[0], input[1]);
    }

    static void BigNumerAdd(string num1, string num2)
    {
        Queue<int> queue = new Queue<int>();
        StringBuilder sb = new StringBuilder();
        var s = "";

        if (num1.Length <= num2.Length)
        {
            for (int i = 0; i < num2.Length - num1.Length; i++)
            {
                s += "0";
            }

            num1 = s + num1;
        }
        else
        {
            for (int i = 0; i < num1.Length - num2.Length; i++)
            {
                s += "0";
            }

            num2 = s + num2;
        }

        for (int i = num1.Length - 1; 0 <= i; i--)
        {
            var digit1 = num2[i] - '0';
            var digit2 = num1[i] - '0';
            var prevCarry = 0;

            if (queue.Count > 0)
            {
                prevCarry = queue.Dequeue();
            }

            if (10 <= digit1 + digit2 + prevCarry)
            {
                queue.Enqueue(1);
            }

            sb.Append((digit1 + digit2 + prevCarry) % 10);
        }

        if (queue.Count > 0)
        {
            sb.Append(queue.Dequeue());
        }

        var result = new string(sb.ToString().Reverse().ToArray());
        Console.WriteLine(result);
    }
}