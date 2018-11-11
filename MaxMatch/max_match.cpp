#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

typedef std::vector<std::string> vec_str;

vec_str words = {"hello", "world", "oopsy", "daisy"};

vec_str max_match(std::string str)
{
    vec_str return_vec;
    std::string set = "";

    for (auto &c : str)
    {
        set += c;

        for (auto iter = words.begin(); iter != words.end(); ++iter)
        {
            if (set == *iter)
            {
                return_vec.push_back(set);
                set = "";
            }
        }
    }

    return return_vec;
}



int main() {

    vec_str ret = max_match("helloworldoopsydaisy");

    std::cout << ret[1] << std::endl;

    return 0;
}
