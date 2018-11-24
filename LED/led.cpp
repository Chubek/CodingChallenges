// RedBlueLED.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <vector>
#include <string>
#include <iostream>

std::string LED(std::string red, std::string blue)
{
	int size = red.size();
	std::string result;

	for (int i = 0; i < size; ++i)
	{
		if (red[i] == '0' && blue[i] == '1')
		{
			result += 'B';
		}
		else if (red[i] == '1' && blue[i] == '0')
		{
			result += 'R';
		}
		else if (red[i] == '1' && blue[i] == '1')
		{
			result += 'R';
		}
		else
		{
			result += "";
		}
	}

	return result;
}


int main()
{
	std::cout << LED("010101", "101010");
    return 0;
}

