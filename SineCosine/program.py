import math

def factorial(n):
    factorial = 1
    for i in range(1, n+1):
        factorial *= i

    return factorial


def sine(d):
    serial = 0

    for i in range(0, 360):
        serial += ((-1)**i / (factorial((2 * i) + 1))) * d ** ((2*i) + 1)

    return serial



sine = sine(3.14 / 2)
cosine = math.sqrt(1 - (sine ** 2) )
tangent = sine / cosine
cotangent = cosine / sine

print (sine, cosine, tangent, cotangent)
