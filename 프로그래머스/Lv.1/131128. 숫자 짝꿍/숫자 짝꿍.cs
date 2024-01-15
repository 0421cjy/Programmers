using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

public class Solution {
    public string solution(string X, string Y) {
        string answer = "";
        
        char[] list = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        Dictionary<char, int> dic1 = new Dictionary<char, int>() { { '0', 0 }, { '1', 0 }, { '2', 0 }, { '3', 0 }, { '4', 0 }, { '5', 0 }, { '6', 0 }, { '7', 0 }, { '8', 0 }, { '9', 0 } };
        Dictionary<char, int> dic2 = new Dictionary<char, int>() { { '0', 0 }, { '1', 0 }, { '2', 0 }, { '3', 0 }, { '4', 0 }, { '5', 0 }, { '6', 0 }, { '7', 0 }, { '8', 0 }, { '9', 0 } };

        StringBuilder newstring = new StringBuilder();

        for (int i = 0; i < X.Length; i++)
        {
            dic1[X[i]]++;
        }

        for (int i = 0; i < Y.Length; i++)
        {
            dic2[Y[i]]++;
        }

        for (int i = 0; i < list.Length; i++)
        {
            var count1 = dic1[list[i]];
            var count2 = dic2[list[i]];

            var min = Math.Min(count1, count2);
            newstring.Append(list[i], min);
        }

        if (newstring.Length <= 0)
        {
            answer = "-1";
        }
        else if (newstring.ToString().All(x => x == '0'))
        {
            answer = "0";
        }
        else
        {
            answer = StringSort(newstring.ToString());
        }

        return answer;
    }
    
    public string StringSort(string s)
    {
        char[] chars = s.ToCharArray();
        Array.Sort(chars, (x, y) => y.CompareTo(x));

        return new string(chars);
    }
}