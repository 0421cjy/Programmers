using System;
using System.Collections.Generic;
using System.IO;

public partial class Program
{
    static void Main(string[] args)
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        var sr = new StreamReader(Console.OpenStandardInput());

        var input = sr.ReadLine().Split();
        var count = Int32.Parse(input[0]);
        var searchCount = Int32.Parse(input[1]);

        var dic = new Dictionary<string, string>();

        for (int i = 0; i < count; i++) 
        {
            var input2 = sr.ReadLine().Split();
            dic.Add(input2[0], input2[1]);
        }

        for (int i = 0; i < searchCount; i++)
        {
            var input3 = sr.ReadLine();
            sw.WriteLine(dic[input3]);
        }

        sw.Close();
        sr.Close();
    }
}