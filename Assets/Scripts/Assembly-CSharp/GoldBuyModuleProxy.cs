using System;
using PureMVC.Patterns;

public class GoldBuyModuleProxy : Proxy
{
	public class Transfer
	{
		public CoinExchangeSource buytype;

		public long gold;

		public Action<int> callback;

		public bool isOpenPreCurrency;

		public Action<bool> closeCallback;
	}

	public new const string NAME = "GoldBuy";

	public GoldBuyModuleProxy(object data)
	{
	}
}
