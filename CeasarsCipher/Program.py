def cipher(direction, shift, text):
    text_split = list(text)

    text_split = [ord(i) for i in text_split]

    text_shift = [str(i+(direction*shift)) for i in text_split]

    return str.join(',', text_shift)


def decipher(direction, shift, text):
    text_split = str.split(text, ',')
    
    print(text_split)
    
    text_shift = [chr(int(i)-(direction*shift)) for i in text_split]

    return str.join('', text_shift)


