using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public partial class Program
{
    static void Main(string[] args)
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        var sr = new StreamReader(Console.OpenStandardInput());

        var sb = new StringBuilder();

        var dic = new Dictionary<string, int>();

        var input = sr.ReadLine().Split();
        var pokeCount = Int32.Parse(input[0]);
        var qCount = Int32.Parse(input[1]);

        for (int i = 0; i < pokeCount; i++)
        {
            var pokeName = sr.ReadLine();
            dic.Add(pokeName, i + 1);
        }
        
        var list = new List<string>(dic.Keys);

        for (int i = 0; i < qCount; i++) 
        {
            var qName = sr.ReadLine();

            if (Int32.TryParse(qName, out var index))
            {
                var name = list[index - 1];
                sb.AppendLine(name);
            }
            else
            {
                dic.TryGetValue(qName, out var value);
                sb.AppendLine(value.ToString());
            }
        }

        sw.Write(sb.ToString());
        sw.Close();
        sr.Close();
    }
}