#include <iostream>
#include <vector>
#include <algorithm>
long factorial(long num)
{
    long result = 1;

    if (num == 1)
        return 1;

    for (int i = 1; i <= num; ++i)
    {
        result *= i;
    }

    return result;
}

int trailing_zero(long num)
{
    long factorial_num = factorial(num);
    std::vector<int> digits;

    do
    {
        digits.push_back(factorial_num % 10);
        factorial_num /= 10;
    }
    while (factorial_num > 0);

    int cnt = 0;

    if (digits[0] == 0)
    {
        ++cnt;
        int n = 1;
        while (digits[n] == 0)
        {
            ++cnt;
            ++n;
        }
    }

    return cnt;

}

int main() {
    std::cout << trailing_zero(5) << std::endl;
    return 0;
}
