import requests
from bs4 import BeautifulSoup

def horoscope(url):
    url_ = url
    page = requests.get(url_)

    soup = BeautifulSoup(page.text, "html.parser")

    horoscope_ = soup.findAll("div", {"class": "block-horoscope-text f16 l20"}, text=True)[0].text

    return horoscope_

if __name__ == '__main__':
    rinput = input("Enter your sign: ")
    sign = str.lower(rinput)
    sign = str.strip(sign)
    url = ''

    signs = ['aries', 'taurus', 'gemini', 'cancer', 'leo', 'virgo', 'libra', 'scorpio', 'sagitarius', 'capricorn',
             'aquarius', 'pisces']

    for index, sign_ in enumerate(signs):
        if sign == sign_:
            url = "https://www.horoscope.com/us/horoscopes/general/horoscope-general-daily-today.aspx?sign={0}".format(
                index + 1
            )

    print (horoscope(url))


