using System;
using PureMVC.Interfaces;
using PureMVC.Patterns;

public class PopWindowProxy : Proxy, IProxy, INotifier
{
	public class Transfer
	{
		public string title;

		public string content;

		public Action<bool> callback;

		public string sureString;

		public string closeString;

		public bool switchButtonPos;
	}

	public new const string NAME = "PopWindowProxy";

	public PopWindowProxy(object data)
	{
	}
}
