using System;
using PureMVC.Patterns;

public class MazeSmithyShopProxy : Proxy
{
	public class Transfer
	{
		private Action<object> callback;

		public Transfer(Action<object> callback)
		{
		}

		public void InvokeCallback(object o)
		{
		}
	}

	public new const string NAME = "MazeSmithyShopProxy";

	public MazeSmithyShopProxy(object data)
	{
	}
}
