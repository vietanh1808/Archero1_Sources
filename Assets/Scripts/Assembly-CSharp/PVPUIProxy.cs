using System;
using PureMVC.Patterns;

public class PVPUIProxy : Proxy
{
	public class Transfer
	{
		public Action callback_create;

		public Action callback_join;

		public string str_desc;

		public string str_title;
	}

	public new const string NAME = "PVPUIProxy";

	public PVPUIProxy(object data)
	{
	}
}
