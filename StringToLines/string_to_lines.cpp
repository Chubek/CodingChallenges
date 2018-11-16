#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

std::string to_lines(std::vector<int> widths, std::string str)
{
    int width_count = 0;
    std::vector<int> return_vec;
    std::string line;

    for (auto &c : str)
    {
        if (width_count < 100)
        {
            line += c;
            width_count += widths[c - 'a' + 1];
        }
        else if (width_count == 100)
        {
            line += '\n';
            width_count = 0;
        }
    }

    return line;
}


int main() {

    std::vector<int> widths = {10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10};
    std::string str = "abcdefghijklmnopqrstuvwxyz";

    std::cout << to_lines(widths, str) << std::endl;
    return 0;
}
