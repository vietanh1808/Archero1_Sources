using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;
using UnityEngine;

public class PurchaseManager : MonoBehaviour
{
	private const string Tag = "PurchaseManager";

	private IPurchaseLogic curLogic;

	public static PurchaseManager Instance { get; private set; }

	private void Start()
	{
	}

	private void init()
	{
	}

	public bool IsValid()
	{
		return false;
	}

	public IPurchaseLogic GetCurLogic()
	{
		return null;
	}

	public bool IsPurchasing()
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

	public string GetProduct_localpricestring(string productId)
	{
		return null;
	}

	public string GetProductID(int index)
	{
		return null;
	}

	public void SetOpenSource(ShopOpenSource source)
	{
	}

	public ShopOpenSource GetOpenSource()
	{
		return ShopOpenSource.ESHOP_PAGE;
	}

	public List<Drop_DropModel.DropData> GetGotList(CRespInAppPurchase data, List<Drop_DropModel.DropData> currencylist)
	{
		return null;
	}

	public void OnPurchaseClicked(string productId, Action<bool, CRespInAppPurchase> callback = null, int shop_rowid = 0)
	{
	}

	private void Update()
	{
	}

	public void OnPurchaseSucceed(string productId)
	{
	}

	public void OnResume()
	{
	}
}
