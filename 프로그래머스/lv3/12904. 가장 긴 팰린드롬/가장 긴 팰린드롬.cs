using System;
using System.Linq;

public class Solution {
    public int solution(String s)
    {
        if (s.Length <= 1) return 1;

        int count = 0;

        for (int window = s.Length; 0 < window; window--)
        {
            if (window < count) return count;

            for (int j = 0; j + window <= s.Length; j++)
            {
                if (isPandrome(s, j, j + window))
                {
                    if (count < window)
                    {
                        count = window;
                    }

                    return count;
                }
            }
        }

        return count;
    }

    public bool isPandrome(string s, int start, int end)
    {
        if (s.Length <= 1) return true;
        if (end < start) return true;

        if (s[start] == s[end - 1])
        {
            return isPandrome(s, start + 1, end - 1);
        }

        return false;
    }
}