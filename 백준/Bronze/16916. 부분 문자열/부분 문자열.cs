using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var s = Console.ReadLine();
        var pattern = Console.ReadLine();

        Console.WriteLine(KMP(s, pattern) ? "1" : "0");
    }

    static bool KMP(string s, string pattern)
    {
        var piList = GetPi(s);

        int begin = 0;
        int match = 0;

        while(begin + match < s.Length)
        {
            if (match < pattern.Length && s[begin + match] == pattern[match])
            {
                match++;

                if (pattern.Length == match)
                {
                    return true;
                }
            }
            else
            {
                if (match == 0)
                {
                    begin++;
                }
                else
                {
                    begin += match - piList[match - 1];
                    match = piList[match - 1];
                }
            }
        }

        return false;
    }

    static List<int> GetPi(string s)
    {
        List<int> list = new List<int>();
        
        for (int i = 0; i < s.Length; i++)
        {
            list.Add(0);
        }

        int begin = 1;
        int match = 0;

        while(begin + match < s.Length)
        {
            if (s[begin + match] == s[match])
            {
                match++;
                list[begin + match - 1] = match;
            }
            else
            {
                if (match == 0)
                {
                    begin++;
                }
                else
                {
                    begin += match - list[match - 1];
                    match = list[match - 1];
                }
            }
        }

        return list;
    }
}