using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string letter) {
        string answer = "";
         var list = new List<string>() 
         { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-",
          ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--",
          "-..-", "-.--", "--.." };
        
        var dic = new Dictionary<string, char>();
        var startIndex = 97;

        foreach (var i in list)
        {
            var alphabet = (char)startIndex;
            dic.Add(i, alphabet);

            startIndex++;
        }

        foreach (var c in letter.Split(" "))
        {
            answer += dic[c];
        }
        
        return answer;
    }
}