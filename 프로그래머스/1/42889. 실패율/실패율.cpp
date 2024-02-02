#include <string>
#include <vector>
#include <tuple>
#include <list>

using namespace std;

vector<int> solution(int N, vector<int> stages) {
    std::list<tuple<int, float>> my_list;
    int totalCount = stages.size();

    for (int i = 1; i < N + 1; i++)
    {
        float count = 0;
        
        for (auto it = stages.begin(); it != stages.end(); it++)
        {
            if (*it == i)
            {
                count++;
            }
        }

        my_list.push_back(tuple<int, float>(i,  count / totalCount));
        totalCount -= count;
    }

    my_list.sort([](const tuple<int, float>& a, const tuple<int, float>& b)
        {
            return get<1>(a) > get<1>(b);
        });

    vector<int> answer;
    for (auto it = my_list.begin(); it != my_list.end(); it++)
    {
        answer.push_back(get<0>(*it));
    }
    
    return answer;
}