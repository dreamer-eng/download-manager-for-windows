using System;
using System.IO;

namespace download
{
	public class Log
	{
		private readonly string _logPath;
		public Log()
		{	
			_logPath = getLogPath();
			
		}

		private string getLogPath()
        {
			string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
			string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
			return Path.Combine(strWorkPath, "log.txt");
		}

		public string logDisplay()
        {
			FileStream stream = new FileStream(_logPath, FileMode.OpenOrCreate);
			StreamReader streamReader = new StreamReader(stream);
			string result = streamReader.ReadToEnd();
			result = result.Replace("&01", "\n");
			streamReader.Close();
			stream.Close();
			return result;
		}


		public string logDisplay(int lines)
		{
			FileStream stream = new FileStream(_logPath, FileMode.OpenOrCreate);
			StreamReader streamReader = new StreamReader(stream);
			string result = "";
			for(int i = 0; i < lines; i++)
            {
				string buf = streamReader.ReadLine();
				if (buf != null)
					result += buf;
				else
					break;
			}
			result = result.Replace("&01", "\n");
			streamReader.Close();
			stream.Close();
			return result;
		}
		public void logAdd(string log_text)
        {
			FileStream stream = new FileStream(_logPath, FileMode.OpenOrCreate);
			StreamReader streamReader = new StreamReader(stream);
			string last_logs = streamReader.ReadToEnd();
			streamReader.Close();
			stream.Close();

			stream = new FileStream(_logPath, FileMode.OpenOrCreate);
			StreamWriter streamWriter = new StreamWriter(stream);
			streamWriter.WriteLine(log_text);
			streamWriter.WriteLine(last_logs);
			streamWriter.Close();
			stream.Close();
        }
	}
}