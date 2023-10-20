using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] arr1, int[] arr2) {

        if (arr1.Length != arr2.Length)
        {
            return arr1.Length > arr2.Length ? 1 : -1;
        }
        
        if (arr1.Sum() == arr2.Sum())
        {
            return 0;
        }
        
        return arr1.Sum() > arr2.Sum() ? 1 : -1;
    }
}