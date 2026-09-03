using System;
using System.Collections.Generic;
using Facebook.Unity;
using GameProtocol;

public class PurchaseLogic_Facebook : PurchaseLogic_Default, IPurchaseLogic
{
	private Dictionary<int, string> mProductList;

	public void Init()
	{
	}

	public bool IsValid()
	{
		return false;
	}

	public bool IsDiscount(string productid)
	{
		return false;
	}

	public bool IsMainActivuty(string productid)
	{
		return false;
	}

	public string GetProduct_localpricestring(int index)
	{
		return null;
	}

	public string GetProduct_localpricestring(string id)
	{
		return null;
	}

	public string GetProductID(int index)
	{
		return null;
	}

	public void OnPurchaseClicked(string productId, Action<bool, CRespInAppPurchase> callback = null)
	{
	}

	private void ConsumePurchase(Purchase purchase)
	{
	}

	public void update()
	{
	}

	public void OnPurchaseSuccess(string productId, string orderId, string json)
	{
	}

	public void OnPurchaseSuccess(string productId, string orderId, CInAppPurchase packet)
	{
	}

	public void OnPurchaseFailed(string code)
	{
	}

	public bool IsPurchasing()
	{
		return false;
	}

	public void OnResume()
	{
	}
}
