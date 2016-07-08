def PigLatin(myString):
    return (myString[1:]+myString[0]) + 'ay';

def Main():
    print(PigLatin(input("Enter a word: ")));
    

Main();
