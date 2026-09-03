using System;
using PureMVC.Interfaces;
using PureMVC.Patterns;

public class PopWindowSimpleProxy : Proxy, IProxy, INotifier
{
	public class Transfer
	{
		public string title;

		public string content;

		public Action callback;
	}

	public new const string NAME = "PopWindowSimpleProxy";

	public PopWindowSimpleProxy(object data)
	{
	}
}
