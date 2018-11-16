#include <iostream>
#include <map>
#include <vector>
#include <string>
#include <cmath>
#include <array>
#include <algorithm>

typedef std::map<std::string, std::vector<int>> bocce_balls;
typedef std::vector<int> int_vec;
typedef std::array<int, 2> int_arr;

std::string bocce(bocce_balls balls, int_arr jack)
{
    auto distance = std::sqrt(std::pow(jack[0], 2)+std::pow(jack[1], 2));
    int red_count = 0;
    int blue_count = 0;

    int_vec red = balls["red"];
    int_vec blue = balls["blue"];

    if (blue.size() != red.size())
    {
        std::cerr << "Balls were different numbers!" << std::endl;
        return "Fail!";
    }

    std::sort(blue.begin(), blue.end());
    std::sort(red.begin(), red.end());

    for (int i = 0; i < blue.size(); ++i)
    {
        if (red[i] > distance && red[i] > blue[i])
            ++red_count;
        else if (blue[i] > distance && blue[i] > red[i])
            ++blue_count;
    }

    
    if (red_count > blue_count)
        return "Red Wins!";
    else if (blue_count > red_count)
        return "Blue Wins!";
    else
        return "Draw!";

}



int main() {

    bocce_balls insert;
    insert["blue"] = {2, 9, 3, 4, 5, 1, 10, 2};
    insert["red"] = {20, 11, 3, 4, 3, 1, 2, 3};
    int_arr dist = {2, 2};

    std::cout << bocce(insert, dist) << std::endl;
    return 0;
}
