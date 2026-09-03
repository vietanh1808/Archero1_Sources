using System;
using System.Collections.Generic;
using GameProtocol;

public class PurchaseLogic_Huawei : PurchaseLogic_Default, IPurchaseLogic
{
	private Dictionary<int, string> mProductList;

	private List<string> m_listInAppProductIds;

	private List<string> m_listSubsProductIds;

	public void Init()
	{
	}

	protected void InitProducts()
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

	public void update()
	{
	}

	public void OnPurchaseSuccess(string productId, string orderId, string json)
	{
	}

	public void OnPurchaseSuccess(string productId, string orderId, CInAppPurchase packet)
	{
	}

	public void OnPurchaseFailed(int code)
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
