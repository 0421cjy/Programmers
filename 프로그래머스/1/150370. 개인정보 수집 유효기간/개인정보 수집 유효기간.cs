using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        Dictionary<string, int> list = new Dictionary<string, int>();
        List<DateTime> plist = new List<DateTime>();

        var t = today.Split(".");
        var now = new DateTime(Int32.Parse(t[0]), Int32.Parse(t[1]), Int32.Parse(t[2]));

        for (int i = 0; i < terms.Length; i++)
        {
            var termsAndMonth = terms[i].Split(" ");
            list.Add(termsAndMonth[0], Int32.Parse(termsAndMonth[1]));
        }

        for (int i = 0; i < privacies.Length; i++)
        {
            var p = privacies[i].Split(" ");
            var s = p[0].Split(".");
            var termMonth = list[p[1]];

            var date = new DateTime(Int32.Parse(s[0]), Int32.Parse(s[1]), Int32.Parse(s[2]));
            date = date.AddMonths(termMonth);

            plist.Add(date);
        }

        List<int> r = new List<int>();

        for (int i = 0; i < plist.Count; i++)
        {
            if (plist[i] <= now)
            {
                r.Add(i + 1);
            }
        }
        
        return r.ToArray();
    }
}