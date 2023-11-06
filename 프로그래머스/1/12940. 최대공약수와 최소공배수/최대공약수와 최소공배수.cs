public class Solution {
    public int[] solution(int n, int m) {
        
        var g = gcd(n, m);
        var l = (n * m) / g;
        
        int[] answer = new int[] {g, l};
        return answer;
    }
    
    public static int gcd(int n, int m)
    {
        while(0 < m)
        {
            int r = n % m;
            n = m;
            m = r;
        }
        
        return n;
    }
}