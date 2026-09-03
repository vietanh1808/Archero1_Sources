using System;
using System.Collections.Generic;
using GameProtocol;
using OneStore;

public class PurchaseLogic_OneStore : PurchaseLogic_Default, IPurchaseLogic
{
	private bool isBinding;

	private Dictionary<string, ProductDetail> netProductList;

	private string[] productIdArray;

	private string purchasingProductId;

	private bool isGettingProduct;

	private float gettingStartTime;

	private bool isIniting;

	private bool isLogin;

	private bool isReceiveNetProduct;

	private bool canGetFirstReward;

	private string productstr;

	private bool b;

	public void Init()
	{
	}

	public void update()
	{
	}

	private void InitCallBack()
	{
	}

	private void DestoryCallBack()
	{
	}

	private void serviceConnectionResult(string result)
	{
	}

	private void isBillingSupportedResult(string result)
	{
	}

	private void getPurchaseSuccessResult(PurchaseData result)
	{
	}

	private void getPurchaseErrorResult(string result)
	{
	}

	private void queryProductsSuccessResult(ProductDetail result)
	{
	}

	private void queryProductsErrorResult(string result)
	{
	}

	private void getPurchaseIntentSuccessResult(PurchaseData result)
	{
	}

	private void getPurchaseIntentErrorResult(string result)
	{
	}

	private void consumeSuccessResult(PurchaseData result)
	{
	}

	private void consumeErrorResult(string result)
	{
	}

	private void manageRecurringSuccessResult(PurchaseData result)
	{
	}

	private void manageRecurringErrorResult(string result)
	{
	}

	private void getLoginIntentEvent(string result)
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

	private void ErrorResult(string result)
	{
	}

	private void SetGettingProduct(bool b)
	{
	}

	private void Send(PurchaseData purchase)
	{
	}

	protected override void SetProgress(bool value)
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
