def SwapList(myList, element1, element2):
    temp = myList[element1];
    myList[element1] = myList[element2];
    myList[element2] = temp;

def InsertionSort():
    myList = [3, 42, 235, 223, 221, 11, 123, 21, 1];

    for i in range(1, len(myList)):
        j = i;
        while (j > 0 and (myList[j] < myList[j-1])):
            SwapList(myList, j, j - 1);
            j -= 1;

    print(myList);

InsertionSort();
