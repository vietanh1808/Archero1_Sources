using System;
using PureMVC.Interfaces;
using PureMVC.Patterns;

public class PopWindowBuyConfirmProxy : Proxy, IProxy, INotifier
{
	public class Transfer
	{
		public string title;

		public string content;

		public CurrencyType icon;

		public string sure;

		public bool showclosebutton;

		public bool showsurebutton;

		public bool showicon;

		public Action callback;

		public int style;
	}

	public new const string NAME = "PopWindowBuyConfirmProxy";

	public PopWindowBuyConfirmProxy(object data)
	{
	}
}
