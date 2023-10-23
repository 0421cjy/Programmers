#include <vector>
#include <iostream>

using namespace std;

vector<int> solution(vector<int> arr) 
{
    vector<int> answer;
    int value = -1;

    for (int i = 0; i < arr.size(); i++)
    {
        if (arr[i] == value) continue;

        value = arr[i];
        answer.push_back(value);
    }

    return answer;
}