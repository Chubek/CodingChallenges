// MexicanWave.cpp : Created by Chubak
//


#include <string>
#include <vector>
#include <iostream>

typedef std::vector<std::string> str_vec;

str_vec mexican_wave(std::string str)
{
	str_vec result;

	for (auto &c : str)
	{
		c = toupper(c);
		result.push_back(str);
		c = tolower(c);
	}

	return result;
}

int main()
{
	str_vec res = mexican_wave("hello world");

	for (auto &str : res)
	{
		std::cout << str << std::endl;
	}
    return 0;
}

