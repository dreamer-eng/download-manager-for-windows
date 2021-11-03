using System;
using System.IO;
using System.ComponentModel;
using System.Net;
using System.Threading;
using System.Collections.Generic;

namespace download
{
    public class download
    {

        public static void Main(string[] args)
        {
            bool[] done = new bool[2] { false, false };
            List<string> url = new List<string>();
            List<string> filePath = new List<string>();
            int timeout = 10;
            Log logsObj = new Log();

            for (int i = 0; i < args.Length; i++)
            {
                if(args[i] == "-u" || args[i] == "--url")
                {
                    string[] ar = args[i + 1].Split(",");
                    for(int j = 0; j < ar.Length; j++)
                    {
                        url.Add(ar[j]);
                    }
                    done[0] = true;
                    i++;
                }
                else if(args[i] == "-d" || args[i] == "--destination")
                {
                    string[] ar = args[i + 1].Split();

                    for(int j = 0; j < ar.Length; j++)
                    {
                        filePath.Add(ar[j]);
                    }
     
                    done[1] = true;
                    i++;
                }
                else if(args[i] == "-t" || args[i] == "timeout")
                {
                    timeout = int.Parse(args[i + 1]);
                    i++;
                }
                else if(args[i] == "-h" || args[i] == "--help")
                {
                    usage();
                    return;
                }
                else if(args[i]=="-o"||args[i]=="--output")
                {
                    string[] ar = args[i + 1].Split(",");

                    for(int j = 0; j < ar.Length; j++)
                    {
                        string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                        string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
                        filePath.Add(System.IO.Path.Combine(strWorkPath, ar[j]));
                    }

                    done[1] = true;
                    i++;
                }
                else if(args[i] == "-l" || args[i] == "--log")
                {
                    if (args.Length > i + 1)
                    {
                        if (args[i + 1] == "clear")
                            clearLogs(logsObj);
                        else
                            log(logsObj, int.Parse(args[i + 1]));
                    }   
                    else
                        log(logsObj);
                    return;
                }
            }

            if (done[0] && done[1])
            {
                Console.WriteLine();
                for (int i = 0; i < url.Count; i++)
                {
                    var success = FileDownloader.DownloadFile(url[i], filePath[i], timeout * 1000);
                    string success_log = "";
                    if (success)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Success!!! \n");
                        Console.ResetColor();
                        success_log = "Success";
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Something went wrong");
                        Console.ResetColor();
                        success_log = "Something went wrong";
                    }
                    DateTime now = DateTime.Now;
                    //&01 is \n
                    string log ="------------------------------" +"&01Download Time: " + now.ToString("F") +
                        "&01    Url:" + url[i] + 
                        "&01    To : " + filePath[i] + 
                        "&01    Result: " + success_log +"&01";
                    addLog(logsObj, log);
                }
                return;
            }
            else
            {
                usage();
                return;
            }
        }
        
        public static void usage()
        {
            DisplayLogo();
            Console.WriteLine(
                @"Usage: download [OPTION]..."+"\n"+
"Download the file from the provided URL."+"\n"+
"Mandatory arguments to long options are mandatory for short options too."+"\n" +
"   -u,--url                    url from which to download the file (string)" +"\n"+
"   -d,--destination            path where the file will be downloaded (string)^(string)"+ "\n"+
"   -o,--output                 path in the current path where the file should be saved (string)" + "\n" +
"   -t,--timeout                maximum waiting time (sec) for a file to be downloaded. Default is 10 sec (int)" + " \n"+
"   -h,--help                   displaying the instructions for using this program"+ "\n"+
"   -l,--log                    displays recently downloaded files (int)" + " \n\n" +
"Example of use:" +"\n"+
"   download -u https://www.google.com/ -d C:/users/user01/Desktop/html.index -t 12 \n"+
"   download -u https://www.google.com/,https://ggames.5v.pl/kctf.zip -o index.html,website.zip" + "\n" +
"   download -l \n"+
"   download -l 5 \n" +
"   download -l clear" + "\n\n\n"
);
        }

        public static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n");
            Console.WriteLine(@"
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
                                                                           ");
            Console.WriteLine("\n");
            Console.ResetColor();
        }

        public static void log(Log logs)
        {
            Console.Write(logs.logDisplay());
        }

        public static void log(Log logs,int lines)
        {
            Console.WriteLine("Logs:");
            Console.Write(logs.logDisplay(lines));
        }
        public static void addLog(Log logs,string log)
        {
            logs.logAdd(log);
        }

        public static void clearLogs(Log logs)
        {
            logs.logClear();
            Console.WriteLine("Logs have been cleared");
        }
      
    }
}