// EasyBalanceChecking.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <string>
#include <vector>
#include <iostream>
#include <numeric>

typedef std::vector<std::string> str_vec;

str_vec separate(std::string given_str, char separator)
{
	str_vec result;
	std::string to_add;

	for (int i = 0; i < given_str.size(); ++i)
	{
		if (given_str[i] != separator)
		{
			to_add += given_str[i];
			
		}
		else if (given_str[i] == separator)
		{
			result.push_back(to_add);
			to_add = "";
		}
	}


	result.push_back(to_add);

	return result;
}

int balance(std::string checkbook)
{
	str_vec lines;
	std::vector<str_vec> words;

	lines = separate(checkbook, '\n');

	for (auto &vec : lines)
	{
		words.push_back(separate(vec, ' '));
	}

	std::vector<int> spent;

	for (int i = 1; i < words.size(); ++i)
	{
		spent.push_back(std::stoi(words[i][2]));
	}

	int total_spent = std::accumulate(spent.begin(), spent.end(), 1);

	return std::stoi(lines[0]) - total_spent;

}

int main()
{
	int ret = balance("1000\n127 Junipers 200\n128 Gin 12");

	std::cout << ret << std::endl;

    return 0;
}

