using System;
using PureMVC.Patterns;

public class SeasonLoadingProxy : Proxy
{
	public class Transfer
	{
		public Action action;
	}

	public new const string NAME = "SeasonLoadingProxy";

	public SeasonLoadingProxy(object data)
	{
	}
}
