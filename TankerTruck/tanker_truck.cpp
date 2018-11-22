// TankTruck.cpp : Written by Chubak
//

#include <iostream>

int tankvol(int h, int d, int vt)
{
	return vt - ((3.14)*((d / 2)*(d / 2))*h);
}

int main()
{
	std::cout << tankvol(21, 40, 35000) << std::endl;
    return 0;
}

