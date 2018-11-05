#include <iostream>
int **flip_and_reverse(int arr[][3], int size_row, int size_col)
{
    int **return_arr = 0;
    return_arr = new int*[size_row];

    for (int i = 0; i != size_row; ++i)
    {
        return_arr[i] = new int[size_col];
        for (int j = 0; j != size_col; ++j)
        {
            auto sub = size_col - 1;
            return_arr[i][j] = arr[i][sub];
        }

        for (int k = 0; k != size_col; ++k)
        {
            if (return_arr[i][k] == 0)
                return_arr[i][k] = 1;
            else if (return_arr[i][k] == 1)
                return_arr[i][k] = 0;
        }
    }

    return return_arr;
}



int main() {

    int arr[1][3] = {{0, 1, 1}};

    std::cout << flip_and_reverse(arr, 1, 3)[0][0] << std::endl;
    return 0;
}
