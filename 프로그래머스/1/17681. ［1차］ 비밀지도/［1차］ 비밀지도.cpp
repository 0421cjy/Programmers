#include <string>
#include <vector>
#include <bitset>

using namespace std;

vector<string> solution(int n, vector<int> arr1, vector<int> arr2) {
    
    string temp = "";

    for (int i = 0; i < n; i++)
    {
        temp += "0";
    }

    vector<string> answer(n, temp);

    for (int i = 0; i < arr1.size(); i++)
    {
        auto binary = std::bitset<16>(arr1[i]).to_string();
        answer[i] = binary.substr(binary.size() - n, n);
    }

    for (int i = 0; i < arr2.size(); i++)
    {
        auto binary = std::bitset<16>(arr2[i]).to_string();
        binary = binary.substr(binary.size() - n, n);
        
        for (int j = 0; j < n; j++)
        {
            if (answer[i][j] == '1') continue;

            answer[i][j] = binary[j];
        }
    }
    
    for (int i = 0; i < answer.size(); i++)
    {
        for (int j = 0; j < answer.size(); j++)
        {
            if (answer[i][j] == '1')
            {
                answer[i][j] = '#';
            }
            else
            {
                answer[i][j] = ' ';
            }
        }
    }
    
    return answer;
}