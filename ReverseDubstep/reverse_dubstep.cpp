// DubStep.cpp : Created by Chubak
//


#include <iostream>
#include <string>

std::string dubstep_reverse(std::string dubstep)
{
	std::string result;

	size_t pos = std::string::npos;

	while ((pos = dubstep.find("WUB")) != std::string::npos)
	{
		dubstep.replace(pos, 3, " ");
		result = dubstep;		
	}

	while ((pos = dubstep.find("   ")) != std::string::npos)
	{
		dubstep.replace(pos, 3, " ");
		result = dubstep;
	}
	
	result.erase(0, 1);

	return result;
}

int main()
{
	std::cout << dubstep_reverse("WUBWUBWUBIWUBWUBWUBAMWUBWUBWUBX") << std::endl;
    return 0;
}

