using System;
using System.Collections.Generic;
using System.Linq;

namespace backjun
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();
            var inputMin = Int32.Parse(Console.ReadLine());

            var addHour = inputMin / 60;
            var restMin = inputMin % 60;

            for (int i = 1; i < addHour + 1; i++)
            {
                var hour = Int32.Parse(input[0]);
                hour++;

                if (hour == 24)
                {
                    hour = 0;
                }

                input[0] = hour.ToString();
            }

            var min = Int32.Parse(input[1]);
            if (min + restMin >= 60)
            {
                var hour = Int32.Parse(input[0]);
                hour++;

                if (hour == 24)
                {
                    hour = 0;
                }

                input[0] = hour.ToString();
            }

            var newMin = (min + inputMin) % 60;
            input[1] = newMin.ToString();

            Console.WriteLine($"{input[0]} {input[1]}");
        }
    }
}