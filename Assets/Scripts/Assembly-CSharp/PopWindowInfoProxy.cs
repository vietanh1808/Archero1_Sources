using System;
using PureMVC.Interfaces;
using PureMVC.Patterns;

public class PopWindowInfoProxy : Proxy, IProxy, INotifier
{
	public class Transfer
	{
		public string title;

		public string content;

		public string sure;

		public bool showclosebutton;

		public bool showsurebutton;

		public Action callback;
	}

	public new const string NAME = "PopWindowInfoProxy";

	public PopWindowInfoProxy(object data)
	{
	}
}
