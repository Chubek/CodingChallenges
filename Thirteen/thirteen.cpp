#include <iostream>
#include <vector>
#include <algorithm>

std::vector<int> fractions = {1, 10, 9, 12, 3, 4};

std::vector<int> to_digit(int num)
{
    int num_modulo = num % 13;
    std::vector<int> digits;

    do
    {
        int digit = num % 10;
        digits.push_back(digit);
        num /= 10;
    }
    while (num > 1);



    return digits;

}

int iterate(std::vector<int> digits)
{
    int i = 0, j = 0;
    std::vector<int> return_vec;

    while (j < fractions.size())
    {
        return_vec.push_back(digits[i]*fractions[j]);
        ++i;
        ++j;

        if (i == fractions.size())
            i = 0;
    }

    int sum = 0;
    for (auto &k : return_vec)
        sum += k;

    return sum;
}

int thirtheen(int number)
{
    int modulo = number % 13;
    int i = iterate(to_digit(number));;

    while (i % 13 != modulo)
    {
        i = iterate(to_digit(i));
    }


    return i;
}


int main() {
    std::cout << thirtheen(6589) << std::endl;
    return 0;
}
