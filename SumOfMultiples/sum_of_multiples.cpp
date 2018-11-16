#include <iostream>
#include <vector>
#include <algorithm>

int multiples(int n)
{
    std::vector<int> fizz;
    std::vector<int> buzz;
    std::vector<int> fizzbuzz;

    for (int i = 1; i < n; ++i)
    {
        if (i % 3 == 0)
            fizz.push_back(i);
        else if (i % 5 == 0)
            buzz.push_back(i);
        else if (i % 3 == 0 && i % 5 == 0)
            fizzbuzz.push_back(i);
    }

    int sum_fizz = 0, sum_buzz = 0, sum_fizzbuzz = 0;

    for (auto &i : fizz)
        sum_fizz += i;
    for (auto &j : buzz)
        sum_buzz += j;
    for (auto &k : fizzbuzz)
        sum_fizzbuzz += k;

    return sum_buzz+sum_fizz+sum_fizzbuzz;
}


int main() {
    std::cout << multiples(10) << std::endl;
    return 0;
}
