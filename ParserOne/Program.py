import math

def Main():
    mainInput = input("Enter the number of students and number of classes: ")
    studentsDetails = []
    studentNames = []
    studentScores = []
    sum = []
    n = 0
    number = float(mainInput[2])

    for i in range(1, int(mainInput[0]) + 1):
        list.append(studentsDetails, input("Enter student number {0}: ".format(i)))

    for students in studentsDetails:
        list.append(studentNames, str.split(students)[0])
        for i in range(1, int(mainInput[2]) + 1):
            list.append(studentScores, float(str.split(students)[i]))


    while n < len(studentScores):
        list.append(sum, math.fsum(studentScores[n:2]) / number)
        n += int(mainInput[2])

    print(math.fsum(sum) / len(sum))

    for m in studentNames:
        for p in sum:
            print("{0} : {1}".format(m, p))

    


Main()
