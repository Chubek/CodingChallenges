#include <iostream>
#include <vector>
#include <algorithm>

bool is_prime(long int n)
{
    if (n == 1)
    {
        return false;
    }
    int i = 2;
    while(i * i <= n)
    {
        if (n % i == 0)
        {
            return false;
        }
        i += 1;
    }

    return true;
}

std::vector<int> backwards_prime(long int left, long int right)
{
    std::vector<int> return_vec;

    for (auto i = left; i <= right; ++i)
    {
        if (is_prime(i))
        {
            std::string num_str = std::to_string(i);
            std::reverse(num_str.begin(), num_str.end());
            int reverse_int = std::stoi(num_str);
            if (is_prime(reverse_int))
            {
                return_vec.push_back(reverse_int);
                std::cout << reverse_int << std::endl;
            }
        }

    }

    return return_vec;
}

int main() {

    std::vector<int> lala = backwards_prime(2, 100);

    return 0;
}
