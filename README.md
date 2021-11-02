# download-manager-for-windows

Usage: download [OPTION]...\n
Download the file from the provided URL.\n
Mandatory arguments to long options are mandatory for short options too.\n
   -u,--url                    url from which to download the file (string)\n
   -d,--destination            path where the file will be downloaded (string)\n
   -o,--output                 path in the current path where the file should be saved (string)\n
   -t,--timeout                maximum waiting time (sec) for a file to be downloaded. Default is 10 sec (int)\n
   -h,--help                   displaying the instructions for using this program\n
\n\n
Example of use:\n
   download -u https://www.google.com/ -d C:/users/user01/Desktop/html.index -t 12\n
   download -u https://www.google.com/,https://ggames.5v.pl/kctf.zip -o index.html,website.zip\n