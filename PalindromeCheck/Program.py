def Reverse(myString):
    myList = list(myString);
    myListReverse = reversed(myList);

    return "".join(myListReverse);

def CheckForPalindrome(myString):
    
    if Reverse(myString) == myString:
        return "is";
    else:
        return "is not";

def Main():

    print("The word you entered {0} a palindrome.".format(CheckForPalindrome(input("Enter a word: "))));

Main();
