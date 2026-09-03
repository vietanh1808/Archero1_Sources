using System;
using PureMVC.Interfaces;
using PureMVC.Patterns;

public class BuyGoldSureProxy : Proxy, IProxy, INotifier
{
	public class Transfer
	{
		public int index;

		public ShopItemGold item;

		public Action<int, ShopItemGold> callback;
	}

	public new const string NAME = "BuyGoldSureProxy";

	public BuyGoldSureProxy(object data)
	{
	}
}
