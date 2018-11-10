#include <iostream>
#include <string>

std::string complement(std::string dna)
{
    for (auto &c : dna)
    {
        switch (c)
        {
            case 'A':
                c = 'T';
                break;
            case 'T':
                c = 'A';
                break;
            case 'C':
                c = 'G';
                break;
            case 'G':
                c = 'C';
                break;
        }
    }

    return dna;
}

int main() {
    std::cout << complement("ATTGC") << std::endl;
    return 0;
}
