#include <iostream>
#include <vector>
#include <random>
#include <string>

std::vector<bool> generate_rand()
{
	std::vector<bool> return_vec;

	for (int i = 0; i < 46; ++i)
	{
		std::random_device seeder;
		std::mt19937 engine(seeder());
		std::uniform_int_distribution<int> dist(0, 10);
		int random_number = dist(engine);

		if (random_number > 0 && random_number <= 5)
		{
			return_vec.push_back(true);
		}
		else if (random_number >= 6 && random_number < 10)
		{
			return_vec.push_back(false);
		}
	}

	return return_vec;
}


std::string DNA()
{
    std::vector<bool> chromosomes = generate_rand();

    std::string return_str = "";

    if (chromosomes[20] == true)
    {
        return_str += "The baby has Down's Syndrome.\n";
    }
    else if (chromosomes[20] == false)
    {
        return_str += "The baby is healthy.\n";

    }

    if (chromosomes[45] == true)
    {
        return_str += "And it's a he!";
    }
    else if (chromosomes[45] == false)
    {
        return_str += "And it's a she!";
    }

    return return_str;

}

int main()
{
	std::cout << DNA() << std::endl;

    return 0;
}
