using System;
using PureMVC.Interfaces;
using PureMVC.Patterns;

public class EventBlackShopProxy : Proxy, IProxy, INotifier
{
	public class Transfer
	{
		public uint[] vecShopIds;

		public Action OnClose;

		public Transfer(uint[] vecShopIds, Action OnClose = null)
		{
		}
	}

	public new const string NAME = "EventBlackShopProxy";

	public EventBlackShopProxy(object data)
	{
	}
}
