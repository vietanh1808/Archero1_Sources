using System;
using PureMVC.Patterns;

public class AdInsideProxy : Proxy
{
	public class Transfer
	{
		public ADSource source;

		public Action finish_callback;
	}

	public new const string NAME = "AdInsideProxy";

	public AdInsideProxy(object data)
	{
	}
}
