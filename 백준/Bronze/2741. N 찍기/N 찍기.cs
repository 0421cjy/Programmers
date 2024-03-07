using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput()))
        {
            var input = Console.ReadLine();
            var num = Int32.Parse(input);

            var result = Enumerable.Range(1, num);
            foreach (var i in result)
            {
                writer.WriteLine(i);
            }
        }
    }
}