// HarshadNumbers.cpp : Created by Chubak 
//

#include <iostream>
#include <vector>
#include <numeric>

bool is_harshad(int n)
{
	std::vector<int> digits;

	int m = n;
	do
	{
		digits.push_back(m % 10);
		m /= 10;
	} while (m > 0);

	int sum = std::accumulate(digits.begin(), digits.end(), 0);

	if (n % sum == 0)
		return true;
	else
		return false;
}

int next_harshad(int n)
{
	++n;
	
	while (!is_harshad(n))
	{
		++n;
	}

	return n;
}

int main()
{
	std::cout << next_harshad(10) << std::endl;
    return 0;
}

