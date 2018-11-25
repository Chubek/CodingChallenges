// PersistentBugger.cpp : Created by Chubak Bidpaa
//


#include <iostream>
#include <numeric>
#include <vector>

std::vector<int> to_digit(int n)
{
	std::vector<int> result;

	do
	{
		result.push_back(n % 10);
		n /= 10;
	} while (n > 0);

	return result;
}

int persistence(int n)
{
	std::vector<int> digits;

	while (digits.size() != 1)
	{
		digits = to_digit(n);
		n = std::accumulate(digits.begin(), digits.end(), 1, std::multiplies<double>());
	}

	return digits[0];
}

int main()
{
	std::cout << persistence(89) << std::endl;
    return 0;
}

