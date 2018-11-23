// MeanSquareError.cpp : Created by Chubak
//

#include <iostream>
#include <vector>
#include <algorithm>
#include <numeric>
#include <cmath>

typedef std::vector<std::vector<int>> int_vec;

int mean_square_error(int_vec vec)
{
	if (vec[0].size() != vec[1].size())
	{
		std::cerr << "Different Sizes!" << std::endl;
		return 0;
	}

	auto size = vec[0].size();
	std::vector<int> diff;

	for (int i = 0; i < size; ++i)
	{
		diff.push_back(std::pow(std::abs(vec[0][i] - vec[1][i]), 2));
	}

	return std::accumulate(diff.begin(), diff.end(), 0) / diff.size();
}



int main()
{
	int_vec insert = { {1, 2, 3}, {4, 5, 6} };
	std::cout << mean_square_error(insert) << std::endl;

    return 0;
}

