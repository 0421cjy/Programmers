#include <string>
#include <vector>
#include <map>

using namespace std;

vector<int> solution(vector<string> name, vector<int> yearning, vector<vector<string>> photo) {
    vector<int> answer(photo.size(), 0);
    map<string, int> nameAndyearning;
    
    for (int i = 0; i < name.size(); i++)
    {
        nameAndyearning.emplace(name[i], yearning[i]);
    }

    for (int i = 0; i < photo.size(); i++)
    {
        auto t = photo[i];
        for (int j = 0; j < t.size(); j++)
        {
            auto iter = nameAndyearning.find(t[j]);
            if (iter != nameAndyearning.end())
            {
                answer[i] += iter->second;
            }
        }
    }
    
    return answer;
}