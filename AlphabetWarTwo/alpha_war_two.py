left = {'w' : 4, 'p' : 3, 'b' : 2, 's' : 1, 't' : 0}
right = {'m' : 4, 'q' : 3, 'd' : 2, 'z' : 1, 'j' : 0}
left_char = {'w': 'm', 'p' : 'q', 'd': 'b', 's': 'z'}
right_char = {'m': 'w', 'q' : 'p', 'b': 'd', 'z': 's'}

def fight(str):
    str.lower()
    left_score = 0
    right_score = 0

    for i in range(0, len(str)):
        if str[i] == 't':
            if i > 0 and i < len(str):
                new_str = str.replace(str[i - 1], right_char[str[i - 1]])
                new_str = str.replace(str[i + 1], right_char[str[i + 1]])
            elif i == 0:
                new_str = str.replace(str[i + 1], right_char[str[i + 1]])
            elif i == len(str) - 1:
                new_str = str.replace(str[i - 1], right_char[str[i - 1]])
        elif str[i] == 'j':
            if i > 0 and i < len(str):
                new_str = str.replace(str[i - 1], left_char[str[i - 1]])
                new_str = str.replace(str[i + 1], left_char[str[i + 1]])
            elif i == 0:
                new_str = str.replace(str[i + 1], left_char[str[i + 1]])
            elif i == len(str) - 1:
                new_str = str.replace(str[i - 1], left_char[str[i - 1]])

    print(new_str)

    for c in new_str:
        if c in left:
            left_score += left[c]
        elif c in right:
            right_score += right[c]



    if right_score > left_score:
        return "Right Wins!"
    elif left_score > right_score:
        return "Left Wins!"
    else:
        return "Draw!"




print(fight("tz"))

