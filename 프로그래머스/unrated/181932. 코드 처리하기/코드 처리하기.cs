using System;

public class Solution {
    public string solution(string code) {
        string answer = "";
        int mode = 0;

        for (int i = 0; i < code.Length; i++)
        {
            if (code[i] == '1')
            {
                if (mode == 1)
                {
                    mode = 0;
                    continue;
                }

                if (mode == 0)
                {
                    mode = 1;
                    continue;
                }
            }

            if (mode == 0)
            {
                if (IsEven(i))
                {
                    answer += code[i];
                }
            }
            else
            {
                if (!IsEven(i))
                {
                    answer += code[i];
                }
            }
        }
        
        if (answer == "")
        {
            answer = "EMPTY";
        }
        
        return answer;
    }
    
    private static bool IsEven(int num)
    {
        return (num % 2 == 0);
    }
}