using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();
        Console.WriteLine(stringAdd(input[0], input[1]));
    }

    static string stringAdd(string n, string m)
    {
        StringBuilder sb = new StringBuilder();
        var carry = 0;

        if (n.Length < m.Length)
        {
            var lenghDiff = m.Length - n.Length;
            for (int i = 0; i < lenghDiff; i++)
            {
                n = '0' + n;
            }
        }

        if (n.Length > m.Length)
        {
            var lenghDiff = n.Length - m.Length;
            for (int i = 0; i < lenghDiff; i++)
            {
                m = '0' + m;
            }
        }

        for (int i = n.Length - 1; 0 <= i; i--)
        {
            var num1 = (n[i] - '0');
            var num2 = (m[i] - '0');

            sb.Append((num1 + num2 + carry) % 10);

            if (num1 + num2 + carry > 9)
            {
                carry = 1;
            }
            else
            {
                carry = 0;
            }
        }

        var newResult = new string(sb.ToString().Reverse().ToArray());

        if (carry == 1)
        {
            newResult = carry + newResult;
        }

        return newResult;
    }
}