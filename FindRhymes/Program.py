import requests
import os
import re

def load_library():
    with open('library.txt', 'r') as library:
        lines = library.readlines()

    return [x for x in lines if not x.startswith(';;;')]

def rhyme(string):

    if os.path.isfile('library.txt'):
        library = load_library()
    else:
        url = "http://svn.code.sf.net/p/cmusphinx/code/trunk/cmudict/cmudict-0.7b"
        response = requests.get(url, stream=True)

        if not response.ok:
            print("Error loading library")

        with open('library.txt', 'wb+') as library:
            for block in response.iter_content(32):
                library.write(block)

    library = load_library()
    string = string.upper()

    phonemes = [y for y in library if y.startswith(string)][0][len(string):]
    phonemes_split = str.strip(phonemes).split(' ')

    matches = [z for z in library if z.endswith(phonemes_split[-2] + ' ' + phonemes_split[-1] + '\n')]
    matches = [z.strip().split(' ') for z in matches]

    return matches

