#include <vector>
#include <algorithm>

using namespace std;

int solution(vector<int> nums)
{
    auto pickCount = nums.size() / 2;

    sort(nums.begin(), nums.end());
    auto uit = unique(nums.begin(), nums.end());
    nums.erase(uit, nums.end());

    if (nums.size() < pickCount)
    {
        return nums.size();
    }

    return pickCount;
}