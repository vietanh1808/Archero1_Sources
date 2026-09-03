using System;
using PureMVC.Patterns;

public class SweepProxy : Proxy
{
	public class Transfer
	{
		public Action callback_play;
	}

	public new const string NAME = "SweepProxy";

	public SweepProxy(object data)
	{
	}
}
