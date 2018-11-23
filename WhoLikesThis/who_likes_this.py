def like(given_list):
    if len(given_list) == 0:
        return "No one likes this."
    elif len(given_list) == 1:
        return "{name} Likes this.".format(name=given_list[0])
    elif len(given_list) == 2:
        return "{name1} and {name2} Like this.".format(name1=given_list[0], name2=given_list[1])
    elif len(given_list) == 3:
        return "{name1}, {name2}, and {name3} Like this.".format(name1=given_list[0], name2=given_list[1],
                                                                 name3=given_list[2])
    else:
        return "{name1}, {name2}, and {others} others like this.".format(name1=given_list[0], name2=given_list[1],
                                                                         others=len(given_list) - 2)


print(like({}))
print(like(["Chubak"]))
print(like(["Chubak", "Mahdi"]))
print(like(["Chubak", "Mahdi", "Masoud"]))
print(like(["Chubak", "Mahdi", "Masoud", "Nilufar"]))
