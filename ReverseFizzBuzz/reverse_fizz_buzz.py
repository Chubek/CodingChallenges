def reverse_fizzbuzz(list):
    """A reverse fizzbuzz function."""

    result = [0, 0]
    for i in range(0, len(list)):
        if list[i] == "fizz":
            result[0] = i + 1
        elif list[i] == "buzz":
            result[1] = i + 1

    return result


print(reverse_fizzbuzz([1, 2, "fizz", 4, "buzz"]))
