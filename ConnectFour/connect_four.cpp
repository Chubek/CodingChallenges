#include <iostream>
#include <vector>
#include <string>
#include <map>
#include <algorithm>

typedef std::vector<std::string> str_list;
typedef std::map<std::string, int> int_map;

std::string connect_four(str_list plays)
{
    str_list A;
    str_list B;
    str_list C;
    str_list D;
    str_list E;
    str_list F;
    str_list G;

    for (auto &str : plays)
    {
        switch (str[0])
        {
            case 'A':
                A.push_back(str);
                break;
            case 'B':
                B.push_back(str);
                break;
            case 'C':
                C.push_back(str);
                break;
            case 'D':
                D.push_back(str);
                break;
            case 'E':
                E.push_back(str);
                break;
            case 'F':
                F.push_back(str);
                break;
            case 'G':
                G.push_back(str);
                break;
        }
    }


    if (std::count(A.begin(), A.end(), "A_Red") >= 4)
        return "Red Wins!";
    if (std::count(B.begin(), B.end(), "B_Red") >= 4)
        return "Red Wins!";
    if (std::count(C.begin(), C.end(), "C_Red") >= 4)
        return "Red Wins!";
    if (std::count(D.begin(), D.end(), "D_Red") >= 4)
        return "Red Wins!";
    if (std::count(E.begin(), E.end(), "E_Red") >= 4)
        return "Red Wins!";
    if (std::count(F.begin(), F.end(), "F_Red") >= 4)
        return "Red Wins!";
    if (std::count(G.begin(), G.end(), "G_Red") >= 4)
        return "Red Wins!";

    if (std::count(A.begin(), A.end(), "A_Blue") >= 4)
        return "Blue Wins!";
    if (std::count(B.begin(), B.end(), "B_Blue") >= 4)
        return "Blue Wins!";
    if (std::count(C.begin(), C.end(), "C_Blue") >= 4)
        return "Blue Wins!";
    if (std::count(D.begin(), D.end(), "D_Blue") >= 4)
        return "Blue Wins!";
    if (std::count(E.begin(), E.end(), "E_Blue") >= 4)
        return "Blue Wins!";
    if (std::count(F.begin(), F.end(), "F_Blue") >= 4)
        return "Blue Wins!";
    if (std::count(G.begin(), G.end(), "G_Blue") >= 4)
        return "Blue Wins!";

    if (std::count(A.begin(), A.end(), "A_Red") >= 1 &&
        std::count(B.begin(), B.end(), "B_Red") >= 1 &&
        std::count(C.begin(), C.end(), "C_Red") >= 1 &&
        std::count(D.begin(), D.end(), "D_Red") >= 1) {return "Red Wins!";}


    if (std::count(B.begin(), B.end(), "B_Red") >= 1 &&
        std::count(C.begin(), C.end(), "D_Red") >= 1 &&
        std::count(D.begin(), D.end(), "C_Red") >= 1 &&
        std::count(E.begin(), E.end(), "E_Red") >= 1) {return "Red Wins!";}


    if (std::count(C.begin(), C.end(), "C_Red") >= 1 &&
        std::count(D.begin(), D.end(), "D_Red") >= 1 &&
        std::count(E.begin(), E.end(), "E_Red") >= 1 &&
        std::count(F.begin(), F.end(), "F_Red") >= 1) {return "Red Wins!";}

    if (std::count(D.begin(), D.end(), "D_Red") >= 1 &&
        std::count(E.begin(), E.end(), "E_Red") >= 1 &&
        std::count(F.begin(), F.end(), "F_Red") >= 1 &&
        std::count(G.begin(), G.end(), "G_Red") >= 1) {return "Red Wins!";}


    if (std::count(A.begin(), A.end(), "A_Blue") >= 1 &&
        std::count(B.begin(), B.end(), "B_Blue") >= 1 &&
        std::count(C.begin(), C.end(), "C_Blue") >= 1 &&
        std::count(D.begin(), D.end(), "D_Blue") >= 1) {return "Blue Wins!";}


    if (std::count(B.begin(), B.end(), "B_Blue") >= 1 &&
        std::count(C.begin(), C.end(), "C_Blue") >= 1 &&
        std::count(D.begin(), D.end(), "D_Blue") >= 1 &&
        std::count(E.begin(), E.end(), "E_Blue") >= 1) {return "Blue Wins!";}


    if (std::count(C.begin(), C.end(), "C_Blue") >= 1 &&
        std::count(D.begin(), D.end(), "D_Blue") >= 1 &&
        std::count(E.begin(), E.end(), "E_Blue") >= 1 &&
        std::count(F.begin(), F.end(), "F_Blue") >= 1) {return "Blue Wins!";}

    if (std::count(D.begin(), D.end(), "D_Blue") >= 1 &&
        std::count(E.begin(), E.end(), "E_Blue") >= 1 &&
        std::count(F.begin(), F.end(), "F_Blue") >= 1 &&
        std::count(G.begin(), G.end(), "G_Blue") >= 1) {return "Blue Wins!";}


    return "Draw!";


}


int main() {

    str_list insert =  {
            "A_Red",
            "B_Yellow",
            "A_Red",
            "B_Yellow",
            "A_Red",
            "B_Yellow",
            "G_Red",
            "B_Yellow"
    };

    std::cout << connect_four(insert) << std::endl;
    return 0;
}
