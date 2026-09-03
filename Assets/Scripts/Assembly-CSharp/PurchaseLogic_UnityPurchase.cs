using System;
using System.Collections.Generic;
using GameProtocol;
using UnityEngine.Purchasing;

public class PurchaseLogic_UnityPurchase : PurchaseLogic_Default, IPurchaseLogic, IStoreListener
{
	private Dictionary<int, string> mProductList;

	private IStoreController controller;

	private new ShopOpenSource opensource;

	private IAppleExtensions m_AppleExtensions;

	private bool isEuro;

	private Action DelayedPurchaseFailed;

	private UnityPurchase_DelayExecuter executer;

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

	public ProductMetadata GetProductMetadata(string id)
	{
		return null;
	}

	public string GetProduct_localpricestring(int index)
	{
		return null;
	}

	public string GetProduct_localpricestring(string id)
	{
		return null;
	}

	public void update()
	{
	}

	public string GetProductID(int index)
	{
		return null;
	}

	public new void SetOpenSource(ShopOpenSource source)
	{
	}

	public new ShopOpenSource GetOpenSource()
	{
		return ShopOpenSource.ESHOP_PAGE;
	}

	public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
	{
	}

	private void OnDeferred(Product item)
	{
	}

	public void OnInitializeFailed(InitializationFailureReason error)
	{
	}

	public void OnInitializeFailed(InitializationFailureReason error, string message)
	{
	}

	public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e)
	{
		return PurchaseProcessingResult.Complete;
	}

	private void Send(Product product, string extraPurchaseInfo = null)
	{
	}

	public void DelayPurchaseFailCheck(float delayTime)
	{
	}

	public void OnPurchaseFailed(Product item, PurchaseFailureReason r)
	{
	}

	public void InstantPurchaseFailed(Product item, PurchaseFailureReason r)
	{
	}

	public void OnPurchaseClicked(string productId, Action<bool, CRespInAppPurchase> callback = null)
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
