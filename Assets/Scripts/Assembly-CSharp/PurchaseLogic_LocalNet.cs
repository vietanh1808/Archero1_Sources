using System;
using System.Collections.Generic;
using GameProtocol;

public class PurchaseLogic_LocalNet
{
	private static PurchaseLogic_LocalNet instance;

	private static object Locker;

	private string[] currency_product_ids;

	private Dictionary<string, int> shopProductToRowDict;

	private Dictionary<int, string> shopRowToOrderDict;

	public static PurchaseLogic_LocalNet Instance => null;

	public void init()
	{
	}

	public void uninit()
	{
	}

	public void requestStarBuy(string pid, Action<CRespInAppPurchase, int> action = null, int rowid = 0)
	{
	}

	public void responseIAP(string productId, CRespInAppPurchase data)
	{
	}

	public bool is_only_one_currency(string id)
	{
		return false;
	}

	public void requestIAPSimulator(string pid, Action<CRespInAppPurchase, int> action = null, int rowid = 0)
	{
	}

	public void requestShopPreOrder(int shop_rowid, string productid, Action<STRespCharge, int> action = null)
	{
	}

	public void addIAPPacketItem(CInAppPurchase packet, string productId)
	{
	}

	public void clearIAPRowOrderDict(string productId)
	{
	}

	public int GetShoppingUseRowid(string productid)
	{
		return 0;
	}
}
