def generate_substring(givenstring):
    givenstring_list = []

    for i in range(0, len(givenstring)):
        for j in range(0, len(givenstring)):
            if i != j:
                givenstring_list.append(givenstring[i:j])

    return_list = [givenstring_list[i] for i in range(0, len(givenstring_list)) if givenstring_list[i] != '']

    return reversed(return_list)


def main():
    code_input = raw_input("Enter a string: ")
    substrings_list = generate_substring(code_input)
    temp = ""

    for substrings in substrings_list:
        for i in range(1, len(substrings)):
            if substrings[i - 1] != substrings[i]:
                temp = substrings
                break
        else:
            continue

        break


    print(temp)


main()
