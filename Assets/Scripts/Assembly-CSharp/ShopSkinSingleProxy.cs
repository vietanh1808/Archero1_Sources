using System;
using PureMVC.Interfaces;
using PureMVC.Patterns;

public class ShopSkinSingleProxy : Proxy, IProxy, INotifier
{
	public class Transfer
	{
		public bool isOpenPreCurrency;

		public Action OnCloseEvent;
	}

	public new const string NAME = "ShopSkinSingleProxy";

	public ShopSkinSingleProxy(object data)
	{
	}
}
