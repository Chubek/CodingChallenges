#include <iostream>
#include <vector>
#include <iterator>

std::vector<std::vector<int>> array_partition(std::vector<int> nums)
{
    std::vector<std::vector<int>> return_vec;
    std::vector<int> next;
    for (auto i = nums.begin(); i != nums.end(); ++i )
    {
        auto j = std::next(i, 2);
        next = {i, j};
        return_vec.push_back(next);

    }


    return return_vec;

}


int main() {
    std::vector<int> nums = {1, 2, 3, 4};
    std::vector<std::vector<int>> result = array_partition(nums);

    return 0;
}
