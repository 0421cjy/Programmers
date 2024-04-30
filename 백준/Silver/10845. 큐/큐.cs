using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public partial class Program
{
    static void Main(string[] args)
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        var sr = new StreamReader(Console.OpenStandardInput());

        var q = new Queue<int>();
        var input = sr.ReadLine();
        var count = Int32.Parse(input);

        for (int i = 0; i < count; i++) 
        {
            var command = sr.ReadLine().Split();
            switch (command[0]) 
            {
                case "push":
                    {
                        var n = Int32.Parse(command[1]);
                        q.Enqueue(n);
                        break;
                    }
                case "pop":
                    {
                        if (q.Count <= 0)
                        {
                            sw.WriteLine("-1");
                            break;
                        }

                        sw.WriteLine(q.Dequeue());
                        break;
                    }
                case "size":
                    {
                        sw.WriteLine(q.Count);
                        break;
                    }
                case "empty":
                    {
                        sw.WriteLine(q.Count <= 0 ? "1" : "0");
                        break;
                    }
                case "front":
                    {
                        if (q.Count <= 0)
                        {
                            sw.WriteLine("-1");
                            break;
                        }

                        sw.WriteLine(q.Peek());
                        break;
                    }
                case "back":
                    {
                        if (q.Count <= 0)
                        {
                            sw.WriteLine("-1");
                            break;
                        }

                        sw.WriteLine(q.Last());
                        break;
                    }
            }
        }

        sw.Close();
        sr.Close();
    }
}