#include <iostream>
#include <vector>
#include <algorithm>

bool xo(std::string str)
{
    int x_cnt = 0;
    int o_cnt = 0;

    for (auto &c : str)
    {
        if (c == 'x')
        {
            x_cnt += 1;
        }
        else if (c == 'o')
        {
            o_cnt += 1;
        }

    }

    if (x_cnt == o_cnt)
        return true;
    else if (x_cnt == 0 && o_cnt == 0)
        return true;
    else
        return false;
}


int main() {
    std::cout << xo("xoxo") << std::endl;
    return 0;
}
