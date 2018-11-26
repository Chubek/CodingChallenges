// ColorfulNumbers.cpp : Created by Chubak
//


#include <iostream>
#include <vector>
#include <numeric>
#include <algorithm>

bool colorful(int num)
{
	std::vector<int> digits;
	std::vector<int> multiples;

	do
	{
		digits.push_back(num % 10);
		num /= 10;
	} while (num > 0);

	std::reverse(digits.begin(), digits.end());

	for (auto i : digits)
		multiples.push_back(i);
	
	for (int i = 1; i < digits.size(); ++i)
	{
		multiples.push_back(digits[i - 1] * digits[i]);
	}

	multiples.push_back(std::accumulate(digits.begin(), digits.end(), 1,
		std::multiplies<double>()));

	for (int i = 1; i < multiples.size(); ++i)
	{
		if (multiples[i - 1] == multiples[i])
			return false;
	}

	return true;
}

int main()
{
	std::cout << colorful(292) << std::endl;
    return 0;
}

