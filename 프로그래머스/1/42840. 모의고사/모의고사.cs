using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] answers) {
        Queue<int> list1 = new Queue<int>();
        list1.Enqueue(1);
        list1.Enqueue(2);
        list1.Enqueue(3);
        list1.Enqueue(4);
        list1.Enqueue(5);

        Queue<int> list2 = new Queue<int>();
        list2.Enqueue(2);
        list2.Enqueue(1);
        list2.Enqueue(2);
        list2.Enqueue(3);
        list2.Enqueue(2);
        list2.Enqueue(4);
        list2.Enqueue(2);
        list2.Enqueue(5);

        Queue<int> list3 = new Queue<int>();
        list3.Enqueue(3);
        list3.Enqueue(3);
        list3.Enqueue(1);
        list3.Enqueue(1);
        list3.Enqueue(2);
        list3.Enqueue(2);
        list3.Enqueue(4);
        list3.Enqueue(4);
        list3.Enqueue(5);
        list3.Enqueue(5);

        Dictionary<int, int> dic = new Dictionary<int, int>();
        dic.Add(1, 0);
        dic.Add(2, 0);
        dic.Add(3, 0);

        for (int i = 0; i < answers.Length; i++)
        {
            var item = list1.Dequeue();
            if (answers[i] == item)
            {
                dic[1]++;
            }
            
            list1.Enqueue(item);
        }

        for (int i = 0; i < answers.Length; i++)
        {
            var item = list2.Dequeue();
            if (answers[i] == item)
            {
                dic[2]++;
            }
            
            list2.Enqueue(item);
        }

        for (int i = 0; i < answers.Length; i++)
        {
            var item = list3.Dequeue();
            if (answers[i] == item)
            {
                dic[3]++;
            }
            
            list3.Enqueue(item);
        }

        var maxValue = dic.Max(x => x.Value);
        var list = new List<int>();

        foreach(var i in dic)
        {
            if (i.Value == maxValue)
            {
                list.Add(i.Key);
            }
        }
        
        return list.ToArray();
    }
}