def compress_text(string_text):
    text_dict = {}
    text_split = str.split(string_text, ' ')

    for index, word in enumerate(text_split):
        value = 0
        if word not in text_dict:
            text_dict[word] = index

    to_write = ''

    for words in text_split:
        to_write += str(text_dict[words])
        to_write += ' '

    file = open("file.txt", "w")
    file.write(to_write)
    file.close()

compress_text("hello my baby hello my honey hellow my ragtime gal")
