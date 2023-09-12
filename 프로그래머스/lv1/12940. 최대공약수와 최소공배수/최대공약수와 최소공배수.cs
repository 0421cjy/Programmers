public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[] {gcd(n, m), lcm(n, m)};
        return answer;
    }
    
    int gcd(int n, int m)
    {
        int rest = m % n;
        if (rest == 0)
        {
            return n;
        }
        else
        {
            return gcd(rest, n);
        }
    }
    
    int lcm(int n, int m)
    {
        return (n * m) / gcd(n, m);
    }
}