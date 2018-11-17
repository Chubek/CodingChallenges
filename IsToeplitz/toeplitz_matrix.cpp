#include <iostream>
#include <vector>
#include <algorithm>

typedef std::vector<std::vector<int>> matrix;

bool is_toeplitz(matrix mat)
{
    std::vector<int> diagonal;
    int row = mat.size(), col = mat[0].size();

    for (int i = 0; i < col; ++i)
    {
        diagonal.push_back(mat[i][i]);
    }

    if (std::equal(diagonal.begin() + 1, diagonal.end(), diagonal.begin()))
        return true;
    else
        return false;
}

int main() {

    matrix insert = {{1, 2, 3},
                     {4, 1, 6},
                     {6, 5, 1}};

    std::cout << is_toeplitz(insert) << std::endl;
    return 0;
}
