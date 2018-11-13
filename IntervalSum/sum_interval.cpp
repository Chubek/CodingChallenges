#include <iostream>
#include <vector>
#include <array>

int sum_interval(std::vector<std::array<int, 2>> vec)
{
    int cnt = 0;

    for (int i = 0; i < vec.size(); ++i)
    {
        if (vec[i][2] > vec[i + 1][1])
        {
            cnt += vec[i][2] - vec[i + 1][1];
        }
        else if (vec[i + 1][1] > vec[i][2])
        {
            cnt += vec[i + 1][1] - vec[i][2];
        }
    }

    return cnt;
}


int main() {

    std::array<int, 2> arr1 = {2, 10};
    std::array<int, 2> arr2 = {15, 18};
    std::array<int, 2> arr3 = {5, 10};
    std::array<int, 2> arr4 = {25, 30};

    std::vector<std::array<int, 2>> list = {arr1, arr2, arr3, arr4};
    std::cout << sum_interval(list) << std::endl;
    return 0;
}
