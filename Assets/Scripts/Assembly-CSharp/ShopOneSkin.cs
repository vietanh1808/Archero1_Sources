using System.Collections.Generic;
using UnityEngine;

public class ShopOneSkin : ShopOneBase
{
	public const float itemWidth = 228f;

	public const float itemHeight = 320f;

	public DxxText Text_Title;

	public GameObject goldparent;

	private List<ShopItemSkin> mList;

	private GameObject _itemgold;

	private LocalUnityObjctPool mPool;

	private GameObject itemgold => null;

	protected override void OnAwake()
	{
	}

	protected override void OnInit()
	{
	}

	private void OnOpenWindowSure(int index, ShopItemSkin item)
	{
	}

	private void OnClickBuy(int index, ShopItemSkin item)
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

	private void requestBuy(ShopItemSkin item)
	{
	}

	private void requestBuyIAP(ShopItemSkin item)
	{
	}

	private void showRewards(ShopItemSkin item)
	{
	}

	public override void UpdateUI()
	{
	}
}
