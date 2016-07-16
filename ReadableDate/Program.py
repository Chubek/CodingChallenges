def add_determiner(number):
    if number == 1:
        return "1st"
    elif number == 2:
        return "2nd"
    elif number == 3:
        return "3rd"
    elif number == 21:
        return "21st"
    elif number == 22:
        return "22nd"
    elif number == 23:
        return "23rd"
    else:
        return str(number)+"th"

def display_month(number):
    if number == 1:
        return "January"
    elif number == 2:
        return "February"
    elif number == 3:
        return "March"
    elif number == 4:
        return "April"
    elif number == 5:
        return "May"
    elif number == 6:
        return "June"
    elif number == 7:
        return "July"
    elif number == 8:
        return "August"
    elif number == 9:
        return "September"
    elif number == 10:
        return "October"
    elif number == 11:
        return "November"
    elif number == 12:
        return "December"
    else:
        raise ValueError("Month number is greater than 12")


def friendly_date(date1, date2):
    year1 = date1[0:4]
    year2 = date2[0:4]

    month1 = date1[5:len(date1) - 3]
    month2 = date2[5:len(date2) - 3]

    day1 = date1[8:len(date1) + 2]
    day2 = date2[8:len(date2) + 2]

    if year1 == year2:
        if month1 == month2:
            return display_month(int(month1)) + ", " + add_determiner(int(day1)) + " - " + add_determiner(int(day2))
        else:
            return display_month(int(month1)) + " " + add_determiner(int(day1)) + " - " + display_month(int(month2)) +\
                   " " + add_determiner(int(day2))

    else:
        return display_month(int(month1)) + " " + add_determiner(int(day1)) + " - " + display_month(int(month2)) + \
               " " + add_determiner(int(day2))


print(friendly_date("2015-03-04", "2016-05-10"))
