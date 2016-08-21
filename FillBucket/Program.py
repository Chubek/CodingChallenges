def findchar(pattern, posx, posy):
    pattern_list = pattern.splitlines()

    return pattern_list[posy][posx]


def fill(pattern, posx, posy, char):
    oldchar = findchar(pattern, posx, posy)

    pattern_list = pattern.splitlines()

    line_split = list(pattern_list[posy])
    line_split[posx] = char
    pattern_list[posy] = ''.join(line_split)

    new_pattern = '\n'.join(pattern_list)

    if posx >= 0 and posx+1 < len(pattern_list[0]) and posy >= 0 and posy+1 < len(pattern_list):
        for i in [-1, 0,  1]:
            if pattern_list[posy+i][posx+1] == oldchar:
                new_pattern = fill(new_pattern, posx+1, posy+i, char)
            elif pattern_list[posy+i][posx-1] == oldchar:
                new_pattern = fill(new_pattern, posx-1, posy+i, char)
            elif pattern_list[posy+1][posx+i] == oldchar:
                new_pattern = fill(new_pattern, posx+i, posy+1, char)
            elif pattern_list[posy-1][posx+i] == oldchar:
                new_pattern = fill(new_pattern, posx+i, posy-1, char)


    return new_pattern

print(fill("xxxx\n0000\n0xx0\nxxxx", 2, 2, 'p'))


