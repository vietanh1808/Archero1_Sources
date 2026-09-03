using System;
using System.Collections.Generic;
using GameProtocol;
using GooglePay;

public class PurchaseLogic_GooglePay : PurchaseLogic_Default, IPurchaseLogic, GooglePayIapInterface
{
	private const string Tag = "PurchaseLogic_GooglePay";

	private string[] productIdArray;

	private Dictionary<string, ProductDetail> netProductList;

	private List<string> m_listInAppProductIds;

	private List<string> m_listSubsProductIds;

	private GooglePayIapManager m_googlePayIapManager;

	public void Init()
	{
	}

	private void InitProducts()
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

	public bool IsPurchasing()
	{
		return false;
	}

	public string[] GetInAppProductIds()
	{
		return null;
	}

	public string[] GetSubsProductIds()
	{
		return null;
	}

	public void OnConnectServerResult(ServiceConnectionResult result)
	{
	}

	public void OnQuerySkuDetails(ProductDetail[] details)
	{
	}

	public void OnPurchaseResult(PurchaseResult result)
	{
	}

	private void Send(PurchaseResult.Order product, string extraPurchaseInfo = null)
	{
	}

	public void OnResume()
	{
	}
}
