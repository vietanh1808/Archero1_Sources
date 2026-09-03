using System;
using System.Collections.Generic;
using GameProtocol;

public class PurchaseLogic_Default
{
	private Dictionary<string, Action<bool, CRespInAppPurchase>> mCallbacks;

	protected bool m_PurchaseInProgress;

	protected ShopOpenSource opensource;

	protected static Dictionary<int, string> mDataInt;

	protected static Dictionary<string, string> mDataString;

	public static float GetDefaultPrice(string productId)
	{
		return 0f;
	}

	protected void add_callback(string productid, Action<bool, CRespInAppPurchase> callback)
	{
	}

	protected Action<bool, CRespInAppPurchase> get_callback(string productid)
	{
		return null;
	}

	protected void excute_callback(string productid, bool value, CRespInAppPurchase response)
	{
	}

	protected virtual void SetProgress(bool value)
	{
	}

	protected bool is_only_one_currency(string id)
	{
		return false;
	}

	public void SetOpenSource(ShopOpenSource source)
	{
	}

	public ShopOpenSource GetOpenSource()
	{
		return ShopOpenSource.ESHOP_PAGE;
	}
}
