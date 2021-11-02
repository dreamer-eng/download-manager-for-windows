# download-manager-for-windows

Usage: download [OPTION]...
Download the file from the provided URL.
Mandatory arguments to long options are mandatory for short options too.
   -u,--url                    url from which to download the file (string)
   -d,--destination            path where the file will be downloaded (string)
   -o,--output                 path in the current path where the file should be saved (string)
   -t,--timeout                maximum waiting time (sec) for a file to be downloaded. Default is 10 sec (int)
   -h,--help                   displaying the instructions for using this program

Example of use:
   download -u https://www.google.com/ -d C:/users/user01/Desktop/html.index -t 12
   download -u https://www.google.com/,https://ggames.5v.pl/kctf.zip -o index.html,website.zip