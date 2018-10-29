//Given a vector of signed itegers, and a target integer, this function returns a pointer to an array of two members. This array //has the indices of the numbers in the given vector which equal the target integer. For example, if the given vector is {2, 7, 15, 19}, the returning array is [0, 1].


int *return_sum(std::vector<int> myVector, int targetNum)
{
    static int sum[2];

    for (int i = 0; i < myVector.size(); ++i)
    {
        for (int j = 1; j < myVector.size(); ++j)
        {
            if (myVector[i] + myVector[j] == targetNum)
            {
                sum[0] = i;
                sum[1] = j;
            }
        }

    }

    return sum;

}
