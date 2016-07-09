def RemoveAsterix(myString):
    myStringList = list(myString)

    if '*' not in myString:
        raise ValueError("String must contain asterix")

    if myStringList[0] == '*':
        del myStringList[0:2]
        

    if myStringList[-1] == '*':
        del myStringList[-2:]
        

    for i in range(0, len(myStringList) - 1):
         if myStringList[i] == '*':
             del myStringList[i-1:i+2]
             break;
             

    return ''.join(myStringList)


def Main():
    print(RemoveAsterix(input("Enter a string: ")))

Main()
