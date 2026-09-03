using System.Collections.Generic;
using GameProtocol;
using UnityEngine;
using XLua;

public class ShopOneDiamondBox : ShopOneBase
{
	public DxxText Text_Title;

	public DxxText Text_Time;

	public RectTransform ActivityUI;

	public List<ShopItemDiamondBoxBase> mList;

	public ShopItemDiamondBoxLarge10 large10;

	public ShopItemDiamondBoxMix boxMix;

	public ShopItemDiamondBoxDragon boxDragon;

	public ButtonCtrl Button_Hint;

	public ButtonCtrl Activity_Hint;

	public DxxText Text_Content;

	public DxxText Text_t;

	private CRespShopBoxActivity CRespShopBoxActivity;

	private long activityEndTime;

	private UISortOrder[] sorts;

	public WindowButtonCtrl wishButton;

	public DxxText Text_Bottle;

	public RedNodeCtrl redNodeCtrl;

	[SerializeField]
	private Vector2 posBtnWishLeft;

	[SerializeField]
	private Vector2 posBtnWishRight;

	[SerializeField]
	private Vector2 posBtnHintLeft;

	[SerializeField]
	private Vector2 posBtnHintRight;

	[SerializeField]
	private RectTransform rtBtnWish;

	[SerializeField]
	private RectTransform rtBtnHint;

	public ShopItemBoxRelics relicsBox;

	public ShopItemBoxManor manorBox;

	public ShopItemBoxPet petBox;

	public ShopItemBoxImprint imprintBox;

	private ScrollRectBase scrollRect;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_GetTextContent;

	private static DelegateBridge __Hotfix0_UpdateNet;

	private static DelegateBridge __Hotfix0_UpdateUI;

	private static DelegateBridge __Hotfix0_OnDeinit;

	private static DelegateBridge __Hotfix0_initScroll;

	private static DelegateBridge __Hotfix0_RefreshBoxStateByRelics;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override void OnInit()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private string GetTextContent(ushort type)
	{
		return null;
	}

	public override void UpdateNet()
	{
	}

	public override void UpdateUI()
	{
	}

	protected override void OnDeinit()
	{
	}

	public void initScroll(ScrollRectBase scroll)
	{
	}

	public override void RefreshBoxStateByRelics()
	{
	}

	private void _003C_003ExLuaBaseProxy_UpdateUI()
	{
	}

	private void _003C_003ExLuaBaseProxy_RefreshBoxStateByRelics()
	{
	}
}
