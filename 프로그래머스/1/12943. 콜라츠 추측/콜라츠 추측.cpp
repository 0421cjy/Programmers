#include <string>
#include <vector>

using namespace std;

int solution(int num) {
    int answer = 0;
    long longNum = num;
    
    while(true)
    {
        if (longNum == 1)
        {
            break;
        }
        
        if (500 <= answer)
        {
            return -1;
        }
        
        if (longNum % 2 == 0)
        {
            answer++;
            longNum /= 2;
            continue;
        }
        else
        {
            answer++;
            longNum *= 3;
            longNum += 1;
            continue;
        }
    }
    
    return answer;
}