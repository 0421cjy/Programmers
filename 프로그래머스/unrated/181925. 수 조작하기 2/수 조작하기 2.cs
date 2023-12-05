using System;
using System.Text;

public class Solution {
    public string solution(int[] numLog) {
        var result = new StringBuilder();

        for (int i = 0; i < numLog.Length - 1; i++)
        {
            if (numLog[i] + 1 == numLog[i + 1])
            {
                result.Append("w");
            }

            if (numLog[i] -1 == numLog[i + 1])
            {
                result.Append("s");
            }

            if (numLog[i] + 10 == numLog[i + 1])
            {
                result.Append("d");
            }

            if (numLog[i] - 10 == numLog[i + 1])
            {
                result.Append("a");
            }
        }
        
        return result.ToString();
    }
}