 //
// Created by Chubak on 11/2/2018.
//

#ifndef UNIQUEMORSE_MORSE_H
#define UNIQUEMORSE_MORSE_H

#include <map>
#include <vector>
#include <string>

struct Morse
{
    Morse() {fill_map();}
    std::string translate(std::string);
    int unique(std::vector<std::string>);
    void fill_map();

private:

    std::map<char, std::string> alphabet;


};







#endif //UNIQUEMORSE_MORSE_H
