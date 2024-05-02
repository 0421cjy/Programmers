using System;
using System.IO;

public partial class Program
{
    static void Main(string[] args)
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        var sr = new StreamReader(Console.OpenStandardInput());

        int[] q = new int[2000000];
        var input = sr.ReadLine();
        var count = Int32.Parse(input);

        var q_count = -1;
        var point = 0;

        for (int i = 0; i < count; i++) 
        {
            var command = sr.ReadLine().Split();
            switch (command[0]) 
            {
                case "push":
                    {
                        var n = Int32.Parse(command[1]);
                        q[++q_count] = n;
                        
                        break;
                    }
                case "pop":
                    {
                        if (q_count < point)
                        {
                            sw.WriteLine("-1");
                            break;
                        }

                        sw.WriteLine(q[point++]);
                        break;
                    }
                case "size":
                    {
                        sw.WriteLine((q_count - point) + 1);
                        break;
                    }
                case "empty":
                    {
                        sw.WriteLine(q_count < point ? "1" : "0");
                        break;
                    }
                case "front":
                    {
                        if (q_count < point)
                        {
                            sw.WriteLine("-1");
                            break;
                        }

                        sw.WriteLine(q[point]);
                        break;
                    }
                case "back":
                    {
                        if (q_count < point)
                        {
                            sw.WriteLine("-1");
                            break;
                        }

                        sw.WriteLine(q[q_count]);
                        break;
                    }
            }
        }

        sw.Close();
        sr.Close();
    }
}