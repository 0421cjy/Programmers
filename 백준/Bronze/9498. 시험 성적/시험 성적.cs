using System;
using System.Collections.Generic;

namespace backjun
{
    public class Program
    {
        static void Main(string[] args)
        {
            var score = Int32.Parse(Console.ReadLine());

            List<(int, int, string)> scoreList = new List<(int, int, string)>()
            {
                (100, 90, "A"), (89, 80, "B"), (79, 70, "C"), (69, 60, "D")
            };

            var r = scoreList.Find(x => x.Item1 >= score && x.Item2 <= score);
            if (r.Item1 == 0)
            {
                Console.WriteLine("F");
            }
            else
            {
                Console.WriteLine(r.Item3);
            }
        }
    }
}