using PureMVC.Interfaces;
using PureMVC.Patterns;

public class ShopSingleProxy : Proxy, IProxy, INotifier
{
	public enum SingleType
	{
		eDiamond = 0
	}

	public class Transfer
	{
		public SingleType type;

		public bool isOpenPreCurrency;
	}

	public new const string NAME = "ShopSingleProxy";

	public ShopSingleProxy(object data)
	{
	}
}
