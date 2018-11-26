// PrimeNumComposition.cpp : Created by Chubak
//

#include <cmath>
#include <map>
#include <string>

bool is_prime(int n)
{
	if (n == 1)
		return false;
	int i = 2;
	while (i * i <= n)
	{
		if (n % i == 0)
			return false;

		++i;
	}

	return true;
}

std::string prime_decompose(int n)
{
	std::map<int, int> divide;

	for (int i = 2; i <= std::sqrt(n); ++i)
	{
		if (is_prime(i))
		{
			divide[i] = 0;

			
			while (n % i == 0)
			{
				divide[i] += 1;
				n /= i;
			}
			
		}
	}

	std::string result;

	for (auto const& x : divide)
	{
		result += '(';
		result += std::to_string(x.first);
		result += '*';
		result += std::to_string(x.second);
		result += ')';
	}

	return result;

}

int main()
{
	std::cout << prime_decompose(50) << std::endl;
    return 0;
}

