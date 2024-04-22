using System;
using System.Collections.Generic;
using System.Linq;

public partial class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var count = Int32.Parse(input);

        Stack<string> stack = new Stack<string>();

        for (int i = 0; i < count; i++)
        {
            var input2 = Console.ReadLine();
            if (input2 == "0")
            {
                stack.Pop();
            }
            else
            {
                stack.Push(input2);
            }
        }

        if (0 < stack.Count) 
        {
            Console.WriteLine(stack.Aggregate(StringAdd));
        }
        else
        {
            Console.WriteLine("0");
        }
    }

    static string StringAdd(string a, string b)
    {
        var len1 = a.Length;
        var len2 = b.Length;

        if (len1 < len2) 
        {
            var diff = len2 - len1;
            for (int i = 0; i < diff ; i++) 
            {
                a = a.Insert(0, "0");
            }
        }
        else if (len2 < len1)
        {
            var diff = len1 - len2;
            for (int i = 0; i < diff; i++)
            {
                b = b.Insert(0, "0");
            }
        }

        var carry = 0;
        var stringSum = "";

        for (int i = a.Length - 1; 0 <= i; i--) 
        {
            var n1 = Int32.Parse(a[i].ToString());
            var n2 = Int32.Parse(b[i].ToString());

            var sum = n1 + n2 + carry;
            if (9 < sum)
            {
                carry = 1;
            }
            else
            {
                carry = 0;
            }

            var stringNum = sum.ToString();
            stringSum += stringNum[stringNum.Length - 1].ToString();
        }

        if (carry == 1)
        {
            stringSum += "1";
        }

        return new string(stringSum.Reverse().ToArray());
    }
}