import random

def winning_door(number, answer):
    host_number = random.randint(1, 3)
    winning_number = random.randint(1, 3)

    while host_number == number:
        host_number = random.randint(1, 3)

    doors = ['door1', 'door2', 'door3']

    winning_doors = doors[winning_number - 1]
    chosen_door = doors[number - 1]
    host_door = doors[host_number - 1]


    if answer == 'yes' and winning_doors == chosen_door:
        return 'won'
    elif answer == 'yes' and not winning_doors == chosen_door:
        return 'lose'
    elif answer == 'no' and winning_doors == host_door:
        return 'won'
    elif answer == 'no' and not winning_doors == host_door:
        return 'lose'




input_num = int(input('Enter a number: "'))
outcomes = []

for i in range(input_num):
    random_num = random.randint(1, 3)
    outcomes.append(winning_door(random_num, 'yes'))
    outcomes.append(winning_door(random_num, 'no'))

yeses = outcomes.count('won')
nos = outcomes.count('lose')

print(yeses / input_num, nos / input_num)
