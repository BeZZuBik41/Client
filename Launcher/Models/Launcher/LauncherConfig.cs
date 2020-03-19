﻿using System;

namespace Launcher
{
	public class LauncherConfig
	{
		public string[] Servers;
		public int Backend;
		public string Email;
		public string Password;
		public string GamePath;
		public bool MinimizeToTray;

		public LauncherConfig()
		{
			Servers = new string[1] { "https://127.0.0.1" };
			Backend = 0;
			Email = "user@emutarkov.com";
			Password = "password";
			GamePath = Environment.CurrentDirectory;
			MinimizeToTray = true;
		}
	}
}
