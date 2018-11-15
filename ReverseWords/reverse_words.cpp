#include <iostream>
#include <algorithm>
#include <string>
#include <vector>
#include <istream>

typedef std::vector<std::vector<std::string>> string_double_list;
typedef std::vector<std::string> string_list;

std::string reverse_str()
{
    string_list words;
    std::string temp;

    while (std::cin >> temp)
    {
        words.push_back(temp);
        if (temp == "Quit")
            break;
    }

    std::string result;

    for (auto &str : words)
    {
        std::reverse(str.begin(), str.end());
        result += str;
    }

    return result;

}


int main() {
    std::cout << reverse_str() << std::endl;
    return 0;
}
