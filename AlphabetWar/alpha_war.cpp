#include <iostream>
#include <map>

std::map<char, int> side_left = {
        {'w', 4},
        {'p', 3},
        {'b', 2},
        {'s', 1}
};

std::map<char, int> side_right = {
        {'m', 4},
        {'q', 3},
        {'d', 2},
        {'z', 1}
};

std::string alpha_war(const std::string &str)
{
    int left_cnt = 0, right_cnt = 0;

    for (auto &s : str)
    {
        if (side_left[s])
            left_cnt += side_left[s];
        else if (side_right[s])
            right_cnt += side_right[s];
        else
        {
            left_cnt += 0;
            right_cnt += 0;
        }
    }

    if (left_cnt > right_cnt)
        return "Left Side Wins!";
    else if (right_cnt > left_cnt)
        return "Righ Side Wins!";
    else
        return "Neither Win!";

}


int main() {
    std::cout << alpha_war("wwwwww") << std::endl;
    return 0;
}
