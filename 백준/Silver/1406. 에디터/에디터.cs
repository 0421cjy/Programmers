using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public partial class Program
{
    static void Main(string[] args)
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        var sr = new StreamReader(Console.OpenStandardInput());

        var s = sr.ReadLine();

        var input = sr.ReadLine();
        var count = Int32.Parse(input);
        var link = new LinkedList<char>(s);
        link.AddLast(' ');
        var cursor = link.Last;

        for (int i = 0; i < count; i++)
        {
            var command = sr.ReadLine().Split();
            switch (command[0]) 
            {
                case "L":
                    {
                        if (cursor.Previous != null)
                        {
                            cursor = cursor.Previous;
                        }
                        break;
                    }
                case "D":
                    {
                        if (cursor.Next != null)
                        {
                            cursor = cursor.Next;
                        }
                        break;
                    }
                case "B":
                    {
                        if (cursor.Previous != null)
                        {
                            link.Remove(cursor.Previous);
                        }
                        break;
                    }
                case "P":
                    {
                        link.AddBefore(cursor, Char.Parse(command[1]));
                        break;
                    }
            }
        }

        link.RemoveLast();

        StringBuilder sb = new StringBuilder();

        foreach (char c in link)
        {
            sb.Append(c);
        }

        sw.WriteLine(sb.ToString());

        sw.Close();
        sr.Close();
    }
}