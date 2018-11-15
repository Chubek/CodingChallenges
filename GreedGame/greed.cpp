#include <iostream>
#include <vector>
#include <random>
#include <map>
#include <ctime>

std::random_device seeder;
std::mt19937 engine(std::time(NULL));
std::uniform_int_distribution<int> dist(1, 6);

typedef std::vector<int> list_type;

int greed(list_type die_rolls)
{
    int ret = 0;
    std::map<int, int> cnt;

    for (int i = 1; i <= 6; ++i)
    {
        cnt[i] = 0;
    }

    for (auto &d : die_rolls)
    {
        ++cnt[d];
    }

    if (cnt[1] == 3)
    {
        ret += 1000;
    }
    if (cnt[1] == 2)
    {
        ret += 200;
    }
    if (cnt[1] == 1)
    {
        ret += 100;
    }
    if (cnt[1] == 4)
    {
        ret += 1100;
    }
    if (cnt[1] == 5)
    {
        ret += 1200;
    }
    if (cnt[2] == 3)
    {
        ret += 200;
    }
    if (cnt[3] == 3)
    {
        ret += 300;
    }
    if (cnt[4] == 3)
    {
        ret += 400;
    }
    if (cnt[5] == 1)
    {
        ret += 50;
    }
    if (cnt[5] == 2)
    {
        ret += 100;
    }
    if (cnt[5] == 3)
    {
        ret += 500;
    }
    if (cnt[5] == 4)
    {
        ret += 550;
    }
    if (cnt[5] == 5)
    {
        ret += 600;
    }
    if (cnt[6] == 3)
    {
        ret += 600;
    }


    return ret;

}


int greed_rand()
{
    list_type rolls_rand;

    for (int i = 1; i <= 5; ++i)
    {
        rolls_rand.push_back(dist(engine));
    }

    return greed(rolls_rand);
}


int main() {

    list_type rolls = {1, 1, 1, 5, 5};
    std::cout << greed(rolls) << std::endl;
    std::cout << greed_rand() << std::endl;

    return 0;
}
