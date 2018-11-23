// MatrixAddition.cpp : Created By Chubak
//

#include <iostream>
#include <vector>

typedef std::vector<std::vector<int>> matrix;

matrix add_matx(matrix mat1, matrix mat2)
{
	matrix result;
	std::vector<int> row;

	for (int i = 0; i < mat1.size(); ++i)
	{
		for (int j = 0; j < mat1[0].size(); ++j)
		{
			row.push_back(mat1[i][j] + mat2[i][j]);
		}

		result.push_back(row);
		row.erase(row.begin(), row.end());
	}

	return result;
}

int main()
{
	matrix mat1 = { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };

	std::cout << add_matx(mat1, mat1)[0][0] << std::endl;

    return 0;
}

