using System;
using PureMVC.Interfaces;
using PureMVC.Patterns;

public class BuySkinSureProxy : Proxy, IProxy, INotifier
{
	public class Transfer
	{
		public int index;

		public ShopItemSkin item;

		public Action<int, ShopItemSkin> callback;
	}

	public new const string NAME = "BuySkinSureProxy";

	public BuySkinSureProxy(object data)
	{
	}
}
