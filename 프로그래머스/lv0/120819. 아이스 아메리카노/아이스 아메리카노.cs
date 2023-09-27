using System;

public class Solution {
    public int[] solution(int money) {
        const int americano = 5500;

        int cup = money / americano;
        int r = money % americano;

        return new int[] { cup, r };
    }
}