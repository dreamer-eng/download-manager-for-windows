

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
                                                                           


<h2>🤠 Usage:</h2> download [OPTION]... <br /> 
Download the file from the provided URL. <br /> 
Mandatory arguments to long options are mandatory for short options too. <br /> 
&nbsp;&nbsp; -u,--url      &nbsp;            url from which to download the file (string) <br /> 
   &nbsp;&nbsp; -d,--destination &nbsp;           path where the file will be downloaded (string) <br /> 
   &nbsp;&nbsp; -o,--output   &nbsp;              path in the current path where the file should be saved (string) <br /> 
   &nbsp;&nbsp; -t,--timeout &nbsp;            maximum waiting time (sec) for a file to be downloaded. Default is 10 sec (int) <br /> 
   &nbsp;&nbsp; -h,--help &nbsp;                  displaying the instructions for using this program <br />
   &nbsp;&nbsp; -l,--log &nbsp;                   displays recently downloaded files (int) <br /> 
 <br />  <br /> 
<h2>👾 Example of use: </h2>
   &nbsp;&nbsp; download -u https://www.google.com/ -d C:/users/user01/Desktop/index.html -t 12 <br /> 
   &nbsp;&nbsp; download -u https://www.google.com/,https://ggames.5v.pl/kctf.zip -o index.html,website.zip <br /> 
   &nbsp;&nbsp; download -l <br />
   &nbsp;&nbsp; download -l 6<br /> 
