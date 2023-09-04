#include <string>
#include <vector>

using namespace std;

int combination(int n, vector<int> money)
{
    vector<int>dp(n + 1, 0);

    dp[0] = 1;

    for (int i = 0;i < money.size();i++) {
        for (int j = 1;j < n + 1;j++) {

            if (j >= money[i]) 
            {
                dp[j] += dp[j - money[i]];
            }
            else 
            {
                continue;
            }
        }
    }

    return dp[n];
}

int solution(int n, vector<int> money) {
    
    int count = combination(n, money);
    return count;
}