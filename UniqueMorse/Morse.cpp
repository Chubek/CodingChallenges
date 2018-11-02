//
// Created by Chubak on 11/2/2018.
//
#include <map>
#include <string>
#include <vector>
#include <iostream>
#include <regex>
#include "Morse.h"

void Morse::fill_map()
{

    char alpha_keys[] = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's',
                         't','u', 'v', 'w', 'x', 'y', 'z'};

    std::string alpha_values[] = {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.",
                                  "---",".--.", "--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};

    for (int i = 0; i != 26; ++i)
    {
        alphabet.insert(std::make_pair(alpha_keys[i], alpha_values[i]));
    }


}

std::string Morse::translate(std::string str)
{
    std::string return_str;

    std::regex lower("^[a-z]+$");
    if (std::regex_match(str, lower))
    {
        for (auto &c : str)
        {
            std::string morse_char = alphabet[c];
            return_str += morse_char;
        }

        return return_str;
    }
    else
    {
        std::cerr << "Characters must be in lower-case letters!" << std::endl;
        return "Error!";

    }


}

int Morse::unique(std::vector<std::string> strs)
{
    int cnt = 0;

    for (int i = 1; i != strs.size(); ++i )
    {
        if (strs[i] == strs[i - 1])
        {
            ++cnt;
        }
    }
}

