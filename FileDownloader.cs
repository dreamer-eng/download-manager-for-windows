﻿using System;
using System.IO;
using System.ComponentModel;
using System.Net;
using System.Threading;

namespace download
{
	public class FileDownloader
	{
		private readonly string _url;
		private readonly string _fullPathWhereToSave;
		private bool _result = false;
		private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(0);

		public FileDownloader(string url, string fullPathWhereToSave)
		{
			if (string.IsNullOrEmpty(url)) throw new ArgumentNullException("url");
			if (string.IsNullOrEmpty(fullPathWhereToSave)) throw new ArgumentNullException("fullPathWhereToSave");
			this._url = url;
			this._fullPathWhereToSave = fullPathWhereToSave;
		}

		public bool StartDownload(int timeout)
		{
			try
			{
				System.IO.Directory.CreateDirectory(Path.GetDirectoryName(_fullPathWhereToSave));

				if (File.Exists(_fullPathWhereToSave))
				{
					File.Delete(_fullPathWhereToSave);
				}

				using (WebClient client = new WebClient())
				{
					var ur = new Uri(_url);
					client.DownloadProgressChanged += WebClientDownloadProgressChanged;
					client.DownloadFileCompleted += WebClientDownloadCompleted;
					client.DownloadFileAsync(ur, _fullPathWhereToSave);
					_semaphore.Wait(timeout);
					return _result && File.Exists(_fullPathWhereToSave);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("Was not able to download file!");
				Console.Write(e);
				return false;
			}
			finally
			{
				this._semaphore.Dispose();
			}
		}

		private void WebClientDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			string loadAnim = "";
			int hash = (int)e.ProgressPercentage / 10;
			for(int i =0; i < 10; i++)
            {
				if (i < hash)
					loadAnim += "#";
				else
					loadAnim += "-";
            }
			Console.Write("\rDownloading "+ _url + " ["+ loadAnim + "] {0}%", e.ProgressPercentage);
		}

		private void WebClientDownloadCompleted(object sender, AsyncCompletedEventArgs args)
		{
			_result = !args.Cancelled;
			if (!_result)
			{
				Console.Write(args.Error.ToString());
			}
			Console.WriteLine(Environment.NewLine + "Download complete!");
			_semaphore.Release();
		}

		public static bool DownloadFile(string url, string fullPathWhereToSave, int timeoutInMilliSec)
		{
			return new FileDownloader(url, fullPathWhereToSave).StartDownload(timeoutInMilliSec);
		}
	}
}
