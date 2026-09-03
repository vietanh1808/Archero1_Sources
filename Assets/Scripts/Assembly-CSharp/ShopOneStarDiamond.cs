using System.Collections.Generic;
using UnityEngine;

public class ShopOneStarDiamond : ShopOneBase
{
	[SerializeField]
	private ButtonCtrl _btnTips;

	public const float itemwidth = 228f;

	public const float itemheight = 320f;

	private const float officalStoreBarHeight = 60f;

	public DxxText Text_Title;

	public DxxText Text_NotReady;

	public GameObject diamondparent;

	private List<ShopItemStarDiamond> mList;

	private GameObject _itemgdiamond;

	[SerializeField]
	private GameObject _goOfficalStoreBar;

	[SerializeField]
	private DxxText _textOfficeStoreTips;

	[SerializeField]
	private ButtonCtrl _btnOfficeStore;

	[SerializeField]
	private DxxText _textOfficeStore;

	public static string[] _starDiamondPrice;

	private LocalUnityObjctPool mPool;

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

	public void RefreshShopItem(List<ShopItemStarDiamond> mlist)
	{
	}

	public override void UpdateUI()
	{
	}
}
