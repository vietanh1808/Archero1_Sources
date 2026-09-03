using System;
using PureMVC.Interfaces;
using PureMVC.Patterns;

public class PopWindowFragmentProxy : Proxy, IProxy, INotifier
{
	public class Transfer
	{
		public string title;

		public string content;

		public string tips;

		public int equipId;

		public string sure;

		public bool showclosebutton;

		public bool showsurebutton;

		public Action callback;
	}

	public new const string NAME = "PopWindowFragmentProxy";

	public PopWindowFragmentProxy(object data)
	{
	}
}
