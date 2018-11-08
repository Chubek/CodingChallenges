#include <iostream>
#include <cmath>

double hydronium(double pH)
{
    return std::pow(10, -pH);
}

double pH(double hydronium)
{
    double ret = std::log10(hydronium);
    return -ret;
}


int main() {
    std::cout << "1) Enter pH to calculate Hydronium (Enter 1 then press Enter)." << std::endl;
    std::cout << "2) Enter Hydronium to calculate pH (Enter 2 then press Enter)." << std::endl;

    double hydronium_ent, pH_ent;
    int entery;

    std::cin >> entery;

    if (entery == 1)
    {
        std::cin >> pH_ent;
        std::cout << "Hydronium is: " << hydronium(pH_ent) << std::endl;
    }
    else if (entery == 2)
    {
        std::cin >> hydronium_ent;
        std::cout << "pH is: " << pH(hydronium_ent) << std::endl;
    }
    else
    {
        std::cerr << "Invaldi Entery;" << std::endl;
    }


    return 0;
}
