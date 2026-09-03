using System;
using PureMVC.Patterns;

public class RateProxy : Proxy
{
	public class Transfer
	{
		public Action closecallback;
	}

	public new const string NAME = "RateProxy";

	public RateProxy(object data)
	{
	}
}
