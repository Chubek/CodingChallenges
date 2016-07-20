import csv


def add(given_string):
    string_split = str.split(given_string, '->')
    dict = {}

    dict[string_split[0]] = str.strip(string_split[1])

    with open('cards.csv', 'a') as file:
        w = csv.DictWriter(file, dict.keys())
        w.writeheader()
        w.writerow(dict)






def read():
    rights = 0
    wrongs = 0
    card_data = {}

    with open('cards.csv', 'r') as file:
        r = csv.DictReader(file)
        for row in r:
            card_data = row



    assert any(card_data), 'Card data was empty'

    
    for key, value in dict.items(card_data):
        print(key)
        wait = input("Press enter to reveal")
        print(value)
        right_or_wrong = input("Were you right Y/N? ")
        if right_or_wrong == 'Y':
            rights += 1
            continue
        elif right_or_wrong == 'N':
            wrongs += 1
            continue

    print("Right Answers: " + str(rights) + "," + "Wrong Answers: " + str(wrongs))


if __name__ == '__main__':
    to_do = input("What do you want to do, read or add?  ")

    if to_do == 'read':
        read()

    elif to_do == 'add':
        to_add = input("Write front and back seperated by ->  ")
        add(to_add)
