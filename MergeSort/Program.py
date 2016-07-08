def ParseListA(listA):
    newListA = sorted(listA);

    return newListA;

    
def MergeSort(listA, listB):
    newListA = ParseListA(listA);    

    newlistB = [i for i in listB if i != 0];

    return sorted(newListA+newlistB);

def Main():
    listAInput = input("Enter List A: ").split(' ');
    listBInput = input("Enter List B: ").split(' ');

    listA = [int(i) for i in listAInput];
    listB = [int(i) for i in listBInput];

    print(MergeSort(listA, listB));

Main()
    
