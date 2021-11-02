# download-manager-for-windows

Usage: download [OPTION]... <br /> 
Download the file from the provided URL. <br /> 
Mandatory arguments to long options are mandatory for short options too. <br /> 
*Tabspace* -u,--url                    url from which to download the file (string) <br /> 
   *Tabspace* -d,--destination            path where the file will be downloaded (string) <br /> 
   *Tabspace* -o,--output                 path in the current path where the file should be saved (string) <br /> 
   *Tabspace* -t,--timeout                maximum waiting time (sec) for a file to be downloaded. Default is 10 sec (int) <br /> 
   *Tabspace* -h,--help                   displaying the instructions for using this program <br /> 
 <br />  <br /> 
Example of use: <br /> 
   *Tabspace* download -u https://www.google.com/ -d C:/users/user01/Desktop/html.index -t 12 <br /> 
   *Tabspace* download -u https://www.google.com/,https://ggames.5v.pl/kctf.zip -o index.html,website.zip <br /> 