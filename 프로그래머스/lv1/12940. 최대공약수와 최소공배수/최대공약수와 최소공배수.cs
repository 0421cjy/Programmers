public class Solution {
    public int[] solution(int n, int m) {
        int a = gcd(n, m);
        int b = lcm(n, m);
        
        int[] answer = new int[] {a, b};
        return answer;
    }
    
    int gcd(int a, int b)
    {
        while(b > 0)
        {
            int temp = a % b;
            a = b;
            b = temp;
        }
        
        return a;
    }
    
    int lcm(int a, int b)
    {
        return (a * b) / gcd(a, b);
    }
}