#upspeed/downspeed indicator
#written by Chubak -> aurlito@riseup.net

import requests
import time
import os

def get_seconds(datetime):
    time = datetime.split(' ')[3].split(':')

    time_hours = int(time[0])
    time_minutes = int(time[1])
    time_seconds = int(time[2])

    return time_hours*360 + time_minutes*60 + time_seconds




def downspeed():
    url = "http://speedtest.ftp.otenet.gr/files/test100k.db"

    current_seconds = get_seconds(time.asctime())

    file = requests.get(url)
    headers = file.headers

    file_size = int(headers['Content-Length'])/1000

    dl_seconds = get_seconds(time.asctime())

    time_difference = dl_seconds - current_seconds

    return round(file_size / time_difference)



def upspeed():
    current_seconds = get_seconds(time.asctime())

    dummy_file = os.path.join(os.getenv('APPDATA'), 'dummy.txt')
    post_url = 'http://httpbin.org/post'
    with open(dummy_file, 'wb') as dummy:
        for i in range (1500):
            dummy.write(str.encode('This is a dummy text. Its sole propose is being uploaded to a server. '))

        dummy.close()

    files = {'file' : open(dummy_file, 'rb')}

    request = requests.post(post_url, data=files)

    headers = request.headers

    file_size = int(headers['Content-Length'])/1000

    dl_seconds = get_seconds(time.asctime())

    time_difference = dl_seconds - current_seconds

    return round(file_size / time_difference)


if __name__ == '__main__':
    while True:
        up = None
        down = None

        if up == None and down == None:
            up = upspeed()
            down = downspeed()

            print('At {0} your Downspeed is: {1}, and your Upspeed is: {2}'.format(time.asctime(), down, up))

            time.sleep(5)

            up = None
            down = None





