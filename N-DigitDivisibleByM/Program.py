def HighestWithN(i):
    return 9 * int(i*'1');

def DivisibleBy():
    myInput = input("Enter two numbers delimited by space: ");
    i = int(myInput[0]);
    k = int(myInput[2]);

    for j in reversed(range(0, HighestWithN(i))):
        if j % k == 0:
            print(j);
            break;

DivisibleBy();
