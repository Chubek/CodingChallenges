#include <iostream>
#include <vector>
#include <algorithm>

void required_data(std::vector<int> nums)
{
    std::cout << "The number of elements is: " << nums.size() << std::endl;

    std::vector<int> nums_copy(nums);
    std::sort(nums_copy.begin(), nums_copy.end());
    nums_copy.erase(unique(nums_copy.begin(), nums_copy.end()), nums_copy.end());

    std::cout << "The number of unique elements is: " << nums_copy.size() << std::endl;

    int once_cnt = 0;
    std::vector<long long int> max_occur;

    for (auto iter = nums.begin(); iter != nums.end(); ++iter)
    {
        max_occur.push_back(std::count(nums.begin(), nums.end(), *iter));
        if (std::count(nums.begin(), nums.end(), *iter) == 1)
            ++once_cnt;
    }

    std::cout << "The number of integers that only appear once is: " << once_cnt << std::endl;

    auto max = std::max_element(max_occur.begin(), max_occur.end());

    std::cout << "The maximum occurance of a number is: " << *max << std::endl;

}

int main() {
    std::cout << "List Operations: " << std::endl;
    required_data({2, 3, 4, 5, 2, -1, -1, 2, 4, 1, 2, 4, 10, 20, 20, 21});
    return 0;
}
