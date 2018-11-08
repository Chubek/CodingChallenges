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
    std::cout << hydronium(6.3) << std::endl;
    std::cout << pH(0.2) << std::endl;
    return 0;
}
