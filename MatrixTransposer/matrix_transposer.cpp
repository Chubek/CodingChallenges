#include <iostream>
#include <vector>

typedef std::vector<std::vector<int>> matrix;

matrix transpose(matrix mat)
{
    matrix ret_mat;

    for (int i = 0; i < mat[0].size(); ++i)
    {
        std::vector<int> temp_mat;
        for (int j = 0; j < mat.size(); ++j)
        {
            temp_mat.push_back(mat[j][i]);
        }

        ret_mat.push_back(temp_mat);
    }

    return ret_mat;
}


int main() {
    std::cout << "Matrix Transposer" << std::endl;

    matrix insert = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
    matrix result = transpose(insert);

    std::cout << result[0][2] << std::endl;

    return 0;
}
