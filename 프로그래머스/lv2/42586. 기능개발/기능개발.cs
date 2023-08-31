using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        int[] answer = new int[] { };
        int count = 0;
        int progressCount = 0;
        List<int> answerList = new List<int>();

        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j < progresses.Length; j++)
            {
                progresses[j] += speeds[j];
            }

            if (count == progresses.Length)
            {
                break;
            }

            if (100 <= progresses[count])
            {
                count++;
                progressCount++;

                for (int k = count; k < progresses.Length; k++)
                {
                    if (100 <= progresses[k])
                    {
                        count++;
                        progressCount++;
                    }
                    else
                    {
                        break;
                    }
                }

                answerList.Add(progressCount);
            }

            progressCount = 0;
        }

        return answerList.ToArray();
    }
}