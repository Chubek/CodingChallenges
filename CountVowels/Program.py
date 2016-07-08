def CountVowels(myString):
    vowels = ['E', 'A', 'O', 'I', 'U'];
    vowelCount = 0;

    string = str.upper(myString);

    for vowel in vowels:
        for letter in string:
            if letter == vowel:
                vowelCount += 1;

    return vowelCount;

def Main():
    print(CountVowels(input("Enger a word: ")));


Main();
