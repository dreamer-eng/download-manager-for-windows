# download-manager-for-windows

    ▓█████▄  ▒█████   █     █░███▄    █  ██▓     ▒█████   ▄▄▄      ▓█████▄ 
    ▒██▀ ██▌▒██▒  ██▒▓█░ █ ░█░██ ▀█   █ ▓██▒    ▒██▒  ██▒▒████▄    ▒██▀ ██▌
    ░██   █▌▒██░  ██▒▒█░ █ ░█▓██  ▀█ ██▒▒██░    ▒██░  ██▒▒██  ▀█▄  ░██   █▌
    ░▓█▄   ▌▒██   ██░░█░ █ ░█▓██▒  ▐▌██▒▒██░    ▒██   ██░░██▄▄▄▄██ ░▓█▄   ▌
    ░▒████▓ ░ ████▓▒░░░██▒██▓▒██░   ▓██░░██████▒░ ████▓▒░ ▓█   ▓██▒░▒████▓ 
     ▒▒▓  ▒ ░ ▒░▒░▒░ ░ ▓░▒ ▒ ░ ▒░   ▒ ▒ ░ ▒░▓  ░░ ▒░▒░▒░  ▒▒   ▓▒█░ ▒▒▓  ▒ 
     ░ ▒  ▒   ░ ▒ ▒░   ▒ ░ ░ ░ ░░   ░ ▒░░ ░ ▒  ░  ░ ▒ ▒░   ▒   ▒▒ ░ ░ ▒  ▒ 
     ░ ░  ░ ░ ░ ░ ▒    ░   ░    ░   ░ ░   ░ ░   ░ ░ ░ ▒    ░   ▒    ░ ░  ░ 
       ░        ░ ░      ░            ░     ░  ░    ░ ░        ░  ░   ░    
     ░                                                              ░      
     ███▄ ▄███▓ ▄▄▄       ███▄    █  ▄▄▄        ▄████ ▓█████  ██▀███       
    ▓██▒▀█▀ ██▒▒████▄     ██ ▀█   █ ▒████▄     ██▒ ▀█▒▓█   ▀ ▓██ ▒ ██▒     
    ▓██    ▓██░▒██  ▀█▄  ▓██  ▀█ ██▒▒██  ▀█▄  ▒██░▄▄▄░▒███   ▓██ ░▄█ ▒     
    ▒██    ▒██ ░██▄▄▄▄██ ▓██▒  ▐▌██▒░██▄▄▄▄██ ░▓█  ██▓▒▓█  ▄ ▒██▀▀█▄       
    ▒██▒   ░██▒ ▓█   ▓██▒▒██░   ▓██░ ▓█   ▓██▒░▒▓███▀▒░▒████▒░██▓ ▒██▒     
    ░ ▒░   ░  ░ ▒▒   ▓▒█░░ ▒░   ▒ ▒  ▒▒   ▓▒█░ ░▒   ▒ ░░ ▒░ ░░ ▒▓ ░▒▓░     
    ░  ░      ░  ▒   ▒▒ ░░ ░░   ░ ▒░  ▒   ▒▒ ░  ░   ░  ░ ░  ░  ░▒ ░ ▒░     
    ░      ░     ░   ▒      ░   ░ ░   ░   ▒   ░ ░   ░    ░     ░░   ░      
           ░         ░  ░         ░       ░  ░      ░    ░  ░   ░          
                                                                           


<h2>Usage:</h2> download [OPTION]... <br /> 
Download the file from the provided URL. <br /> 
Mandatory arguments to long options are mandatory for short options too. <br /> 
&nbsp; -u,--url&nbsp;&nbsp;                    url from which to download the file (string) <br /> 
   &nbsp; -d,--destination&nbsp;&nbsp;            path where the file will be downloaded (string) <br /> 
   &nbsp; -o,--output&nbsp;&nbsp;                 path in the current path where the file should be saved (string) <br /> 
   &nbsp; -t,--timeout &nbsp;&nbsp;               maximum waiting time (sec) for a file to be downloaded. Default is 10 sec (int) <br /> 
   &nbsp; -h,--help  &nbsp;&nbsp;                 displaying the instructions for using this program <br /> 
 <br />  <br /> 
<h2>Example of use: </h2>
   &nbsp; download -u https://www.google.com/ -d C:/users/user01/Desktop/html.index -t 12 <br /> 
   &nbsp; download -u https://www.google.com/,https://ggames.5v.pl/kctf.zip -o index.html,website.zip <br /> 