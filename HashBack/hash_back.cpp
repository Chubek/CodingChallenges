#include <iostream>
#include <string>
#include <algorithm>

std::string hash_back(std::string str)
{
    for (int i = 0; i < str.size(); ++i)
    {
        if (str[i] == '#')
            str.erase(i - 1, 2);
    }

    return str;
}

int main() {
    std::cout << hash_back("Hel#l!#") << std::endl;
    return 0;
}
