using System.Collections.Generic;
using GameProtocol;
using TableTool;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ShopOneStageDiscount : ShopOneBase
{
	public bool isInShopDiscountPanel;

	private static Color[] fontColors;

	private static Color[] fontColorDesc;

	public static Color[] colors;

	private const float Width = 164f;

	[SerializeField]
	private DxxText Text_Title;

	[SerializeField]
	private DxxText Text_Desc;

	[SerializeField]
	private DxxText Text_Price;

	[SerializeField]
	private DxxText Text_Multiply;

	[SerializeField]
	private DxxText Text_Value;

	public GameObject RewardParent;

	public GameObject itemone;

	public GameObject itemadd;

	public ButtonCtrl Button_Click;

	public Image Image_BG;

	public DxxImage Image_Top;

	public DxxImage Image_Bottom;

	public DxxImage Image_Bottom_2;

	public DxxText Text_GoldBefore;

	public DxxText Text_GuidGift;

	public GameObject child;

	public Current_purchaseItem item;

	public GuildBoxButton Button_GuidGift;

	public VIPFlagItem vipItem;

	public GameObject go_StarDiamond;

	public GameObject go_StarDiamondBefore;

	public DxxText text_StarDiamond;

	public DxxText text_StarDiamondBefore;

	private LocalUnityObjctPool mPool;

	private List<ShopOneStageDiscountOneCtrl> mList;

	private List<Drop_DropModel.DropData> rewards;

	private string mID;

	private int mode;

	private int id;

	private int index;

	private static DelegateBridge __Hotfix0_get_sourceName;

	private static DelegateBridge __Hotfix0_IsValid;

	private static DelegateBridge __Hotfix0_OnAwake;

	private static DelegateBridge __Hotfix0_ConfirmPurchase;

	private static DelegateBridge __Hotfix0_OnStarBuy;

	private static DelegateBridge __Hotfix0_CheckBuy;

	private static DelegateBridge __Hotfix0_PurchaseSuccess;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnDeinit;

	private static DelegateBridge __Hotfix0_GetIndex;

	private static DelegateBridge __Hotfix0_showImg;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_UpdateNet;

	private static DelegateBridge __Hotfix0_OnPurchaseSuccess;

	private static DelegateBridge __Hotfix0_Show;

	private static DelegateBridge __Hotfix0_UpdateUI;

	private static DelegateBridge _c__Hotfix0_ctor;

	private string sourceName => null;

	public static bool IsValid()
	{
		return false;
	}

	protected override void OnAwake()
	{
	}

	private void ConfirmPurchase(List<Drop_DropModel.DropData> dropList, Drop_DropModel.DropData dropData)
	{
	}

	private void OnStarBuy(List<Drop_DropModel.DropData> dropList)
	{
	}

	private bool CheckBuy()
	{
		return false;
	}

	private void PurchaseSuccess(CRespInAppPurchase resp, List<Drop_DropModel.DropData> dropList)
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnDeinit()
	{
	}

	private void GetIndex()
	{
	}

	private void showImg()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void UpdateNet()
	{
	}

	private void OnPurchaseSuccess()
	{
	}

	public void Show(bool show)
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
