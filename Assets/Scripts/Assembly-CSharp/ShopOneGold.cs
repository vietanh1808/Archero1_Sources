using System.Collections.Generic;
using UnityEngine;
using XLua;

public class ShopOneGold : ShopOneBase
{
	public const float itemwidth = 228f;

	public DxxText Text_Title;

	public GameObject goldparent;

	private List<ShopItemGold> mList;

	private GameObject _itemgold;

	private GameObject _itemgoldfree;

	private LocalUnityObjctPool mPool;

	private static DelegateBridge __Hotfix0_get_itemgold;

	private static DelegateBridge __Hotfix0_get_itemgoldfree;

	private static DelegateBridge __Hotfix0_OnAwake;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpenWindowSure;

	private static DelegateBridge __Hotfix0_OnClickGold;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_UpdateNet;

	private static DelegateBridge __Hotfix0_OnDeinit;

	private static DelegateBridge _c__Hotfix0_ctor;

	private GameObject itemgold => null;

	private GameObject itemgoldfree => null;

	protected override void OnAwake()
	{
	}

	protected override void OnInit()
	{
	}

	private void OnOpenWindowSure(int index, ShopItemGold item)
	{
	}

	private void OnClickGold(int index, ShopItemGold item)
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void UpdateNet()
	{
	}

	protected override void OnDeinit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnAwake()
	{
	}
}
