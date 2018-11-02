#include <iostream>
#include <bitset>
#include <algorithm>
#include <string>

std::string ConvertToBinary(const unsigned long &integer) //function for converting uLong to binary string
{
    return std::bitset<8>(integer).to_string();
}


unsigned long ConvertToDecimal(const std::string &binary) //function for converting binary string to uLong
{
    return std::bitset<8>(binary).to_ulong();
}

std::string KilltheBit(std::string str, int k) //main function
{
    std::reverse(str.begin(), str.end());
    if (str[k] == '1')
        str[k] = '0';

    std::reverse(str.begin(), str.end());

    return str;

}

unsigned long OverKill(const unsigned long decimalNum, int k) //collateral function
{
    return ConvertToDecimal(KilltheBit(ConvertToBinary(decimalNum), k));
}

int main() {
    std::cout << OverKill(37, 2) << std::endl; //call the collateral function
    return 0;
}
