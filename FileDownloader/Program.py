import urllib.request as urllib
import threading

def file_download(url):
    file_name = str.split(url, '/')[-1]

    u = urllib.urlopen(url)
    f = open(file_name, 'wb')

    meta = u.info()
    file_size = int(meta['content-length'])
    print("Downloading %s: %s bytes" %(file_name, file_size))

    file_size_dl = 0
    block_sz = 8192
    while True:
        buffer = u.read(block_sz)
        if not buffer:
            break

        file_size_dl += len(buffer)
        f.write(buffer)
        status = r"%10d  [%3.2f%%]" % (file_size_dl, file_size_dl * 100. / file_size)
        status = status + chr(8)*(len(status)+1)
        print(status)

    f.close()

url_1 = "http://download.thinkbroadband.com/10MB.zip"
file_1 = threading.Thread(target=file_download, args=(url_1, ))
file_1.start()
