#include <iostream>
#include <string>

bool back_to_origin(const std::string &moves)
{
    signed int vector[] = {0, 0};

    for (auto &c : moves)
    {
        switch (c)
        {
            case 'U':
                vector[1] += 1;
                break;
            case 'D':
                vector[1] -= 1;
                break;
            case 'R':
                vector[0] += 1;
                break;
            case 'L':
                vector[0] -= 1;
                break;
        }
    }

    if (vector[0] == 0 && vector[1] == 0)
        return true;
    else
        return false;
}
