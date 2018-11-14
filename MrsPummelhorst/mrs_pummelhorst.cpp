#include <iostream>
#include <algorithm>
#include <vector>
#include <cmath>

typedef std::vector<int> list_type;
typedef std::vector<std::vector<int>> double_list_type;

list_type consec_list(list_type &nums)
{
    list_type ret;
    auto half_size = std::ceil(nums.size() / 2);

    //std::cout << half_size << std::endl;

    for (int i = 0; i < half_size; ++i)
    {
        ret.push_back(nums[i]);


    }

    nums.erase(nums.begin(), nums.begin() + ret.size());



    return ret;

}

double_list_type pummelhorst(list_type list)
{
    double_list_type ret;

    while (list.size() > 1)
    {
        ret.push_back(consec_list(list));
        std::cout << list.size() << std::endl;
    }


    return ret;
}


int main() {
    list_type arg = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    double_list_type list = pummelhorst(arg);


    return 0;
}
