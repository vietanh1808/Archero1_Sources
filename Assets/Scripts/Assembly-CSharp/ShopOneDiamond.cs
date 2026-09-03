using System.Collections.Generic;
using UnityEngine;
using XLua;

public class ShopOneDiamond : ShopOneBase
{
	public const float itemwidth = 228f;

	public const float itemheight = 320f;

	public DxxText Text_Title;

	public DxxText Text_NotReady;

	public GameObject diamondparent;

	private List<ShopItemDiamond> mList;

	private List<string> PurchaseDoubleList;

	private GameObject _itemgdiamond;

	private LocalUnityObjctPool mPool;

	private static DelegateBridge __Hotfix0_get_itemgdiamond;

	private static DelegateBridge __Hotfix0_OnAwake;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnDeinit;

	private static DelegateBridge __Hotfix0_OnClickDiamond;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_UpdateNet;

	private static DelegateBridge __Hotfix0_RefreshShopItem;

	private static DelegateBridge __Hotfix0_UpdateUI;

	private static DelegateBridge _c__Hotfix0_ctor;

	private GameObject itemgdiamond => null;

	protected override void OnAwake()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnDeinit()
	{
	}

	private void OnClickDiamond(string productID)
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void RefreshText()
	{
	}

	public override void UpdateNet()
	{
	}

	public void RefreshShopItem(List<string> list, List<ShopItemDiamond> mlist)
	{
	}

	public override void UpdateUI()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnAwake()
	{
	}

	private void _003C_003ExLuaBaseProxy_UpdateUI()
	{
	}
}
