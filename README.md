# download-manager-for-windows

##Usage: download [OPTION]... <br /> 
Download the file from the provided URL. <br /> 
Mandatory arguments to long options are mandatory for short options too. <br /> 
   -u,--url                    url from which to download the file (string) <br /> 
   -d,--destination            path where the file will be downloaded (string) <br /> 
   -o,--output                 path in the current path where the file should be saved (string) <br /> 
   -t,--timeout                maximum waiting time (sec) for a file to be downloaded. Default is 10 sec (int) <br /> 
   -h,--help                   displaying the instructions for using this program <br /> 
 <br />  <br /> 
##Example of use: <br /> 
   download -u https://www.google.com/ -d C:/users/user01/Desktop/html.index -t 12 <br /> 
   download -u https://www.google.com/,https://ggames.5v.pl/kctf.zip -o index.html,website.zip <br /> 