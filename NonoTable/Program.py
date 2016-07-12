def nono_descriptor(given_string):
    number_of_lines = given_string.count('\n') #number of line breaks
    length_of_string = len(given_string) #length of the given string

    if number_of_lines != 4 and length_of_string != 29:
        raise Exception("You need exactly four line breaks and 25 characters!") #throw exception if conditions don't match

    rows_split = [] #list that contains each line split
    columns_list = [] #list that contains columns
    rows_list = [] #list that contains rows

    list_of_lines = given_string.split('\n') #split the string by line break

    for each_line in list_of_lines:
        rows_split.append(list(each_line)) #populate rows list with split up characters
        columns_list.append(each_line.count('*')) #populate columns list with the number of asterisks in each column

    for i in range(5):
        temp_list = [row[i] for row in rows_split]
        rows_list.append(temp_list.count('*'))

    print (columns_list, rows_list)


nono_descriptor('0*0*0\n***00\n****0\n*0*0*\n****0')
