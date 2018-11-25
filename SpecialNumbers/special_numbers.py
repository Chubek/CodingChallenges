import math

def special_check(num, expontent):
    digits = []
    sumof = []

    digit_num = num
    digits.append(digit_num % 10)
    digit_num /= 10
    while (digit_num > 1):
        digits.append(int(digit_num % 10))
        digit_num /= 10

    digits.reverse()

    for p in range(0, len(digits)):
        sumof.append(math.pow(digits[p], expontent+p))

    sum_of_sum = sum(sumof)

    return sum_of_sum / num


print(special_check(89, 1))
