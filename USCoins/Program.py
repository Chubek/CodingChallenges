def calculate_coinage(number):
    modulo = number % round(number)
    number_of_quarters = round(number) / 0.25
    number_of_dimes = round(modulo / 0.10)
    number_of_nickels = round((modulo - number_of_dimes/10) / 0.05)
    number_of_pennies = round((modulo - number_of_dimes/10) / 0.01)

    return [number_of_quarters, number_of_dimes, number_of_nickels, number_of_pennies]


print(calculate_coinage(1.23))
