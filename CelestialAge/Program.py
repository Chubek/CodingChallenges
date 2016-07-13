def calculate_days(age):
    leap_days = 0 #holds number of leap days
    leap_years_list = [i for i in range(age) if i % 4 == 0] #holds the essence of leap years

    for j in leap_years_list:
        if j % 4 == 0 and j % 100 != 0:
            leap_days += 1 #if leap years are divisible by four and not divisible by a hundred, add to leap days

    return (age * 365) - leap_days


def calculate_celestial_age(planet, age):
    number_of_days = calculate_days(age) #calculate the days in age

    assert str.islower(planet), "Planet name must be entered in lower case e.g. 'mercury'" #if planet name is in lowercase, give error

    days_in_year = {"mercury": 88, "venus": 224, "earth": 365, "mars": 687, "jupiter": 4332, "saturn": 10759, "uranus": 30688,
                    "neptune": 60182} #days in each planet's year

    if planet == "mercury":
        return number_of_days / days_in_year["mercury"]
    elif planet == "venus":
        return number_of_days / days_in_year["venus"]
    elif planet == "earth":
        return number_of_days / days_in_year["earth"]
    elif planet == "mars":
        return number_of_days / days_in_year["mars"]
    elif planet == "jupiter":
        return number_of_days / days_in_year["jupiter"]
    elif planet == "saturn":
        return number_of_days / days_in_year["saturn"]
    elif planet == "uranus":
        return number_of_days / days_in_year["uranus"]
    elif planet == "neptune":
        return number_of_days / days_in_year["neptune"]
    else:
        raise Exception("Unknown Planet! Are you sure you've enter a planet?")


age = 23

planets = ["mercury", "venus", "earth", "mars", "jupiter", "saturn", "uranus", "neptune"]

for planet in planets:
    print(calculate_celestial_age(planet, age))








