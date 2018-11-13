#include <iostream>
#include <vector>
#include <string>
#include <cmath>

const int height = 40, width = 80;
typedef std::vector<double> tuple;

tuple coord_to_complex(double i, double j)
{
    double real = (4*i) / (width - 1) - 2.0;
    double imaginary = (2.2 * j) / (height - 1) - 1.1;

    tuple ret = {real, imaginary};

    return ret;


}

bool is_in_mandelbrot(tuple re_im)
{
    auto cr = re_im[0], ci = re_im[1];
    auto zr = cr, zi = ci;

    for (int t = 0; t <= 1000; ++t)
    {
        zr = (std::pow(zr, 2) - std::pow(zi, 2)) + cr;
        zi = (2*zi*zr) + ci;

        if (std::sqrt(std::pow(zr, 2) + std::pow(zi, 2)) > 2)
            return false;
    }

    return true;

}

std::string print_set()
{
    std::string ret = "";

    for (int i = 0; i <= height; ++i)
    {
        for (int j = 0; j <= width; ++j)
        {
            if (is_in_mandelbrot(coord_to_complex(j, i)))
            {
                ret += '*';
            }
            else
            {
                ret += ' ';
            }


        }

        ret += '\n';
    }

    return ret;
}


int main() {
    std::cout << print_set() << std::endl;
    return 0;
}
