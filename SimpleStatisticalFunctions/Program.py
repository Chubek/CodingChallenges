def Mean(*params): #mean is the average of a given list of numbers;
    sum = 0;

    for number in params:
        for i in number:
            sum += i;

    listLength = len(params[0]);

    return sum / listLength;

def Deviation(*params): #deviation is the difference between a number and the average of that group power 2
    myList = params[0];
    average = Mean(myList);
    
    deviationList = [(average - myList[i]) ** 2 for i in range(len(myList))];

    return deviationList;

def Variance(*params): #Variange is the average of deviation
    deviationList = Deviation(params[0]);

    return Mean(deviationList);

def CalculateAll():
    list = [2, 4, 4, 4, 5, 5, 7, 9];

    print(Mean(list));
    print(Deviation(list));
    print(Variance(list));


CalculateAll();
