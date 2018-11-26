import math
def comp(aList, bList):
    aList.sort()
    bList.sort()

    squared = []

    for i in bList:
        squared.append(math.sqrt(i))


    if squared == aList:
        return True
    else:
        return False


print(comp([121, 144, 19, 161, 19, 144, 19, 11], [121, 14641, 20736, 361, 25921, 361, 20736, 361]))
