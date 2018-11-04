#include <iostream>
#include <vector>

std::vector<int> double_trouble(std::vector<int> nums, int target)
{
    for (int i = 1; i != nums.size(); ++i)
    {

        if (nums[i] + nums[i - 1] == target)
        {
            nums.erase(nums.begin() + i);

        }
    }

    return nums;
}


int main() {

    std::vector<int> nums = {1,2,3,4,5};
    std::vector<int> return_nums = double_trouble(nums, 3);
    for (auto &i : return_nums)
        std::cout << i;

    return 0;
}
