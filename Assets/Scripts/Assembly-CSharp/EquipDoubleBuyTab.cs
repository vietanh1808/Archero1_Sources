using System.Collections.Generic;
using GameProtocol;
using TableTool;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class EquipDoubleBuyTab : MonoBehaviour
{
	private class ItemDisplayData
	{
		public bool isEquip;

		public LocalSave.EquipOne equipOne;

		public Drop_DropModel.DropData dropData;
	}

	public const int PriceType_Diamond = 2;

	public const int PriceType_Money = 3;

	private const float Width = 180f;

	public DxxText Text_Title;

	public DxxText Text_Price_Pay;

	public DxxText Text_GoldBefore_Pay;

	public DxxText Text_Discount;

	public DxxText Text_Value;

	public DxxText Text_CountDown;

	public Image Image_RedLine_Pay;

	public Image Image_BG;

	public Image Image_Light;

	public ButtonCtrl Button_Pay;

	public ButtonCtrl Button_Close;

	public GameObject DiscountNode;

	public EquipOneCtrl equipWeaponCtrl;

	public EquipOneCtrl equipWearCtrl;

	public EquipOneCtrl Equip_One;

	private List<EquipOneCtrl> Equips;

	public PropOneEquip Prop_One_Equip;

	private List<PropOneEquip> Props;

	public RectTransform Reward_Parent;

	private Shop_Push pushData;

	private List<Drop_DropModel.DropData> currencyList;

	private PushPackUICtrl ctrl;

	public VIPFlagItem vipItem;

	public ButtonCtrl Button_Star;

	public DxxText Text_Star;

	private const int MAX_ITEMS_PER_LINE = 4;

	private const int ITEM_SIZE_X = 80;

	private const int ITEM_SIZE_Y = 80;

	private List<Drop_DropModel.DropData> showPropList;

	private float timer;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge __Hotfix0_InitIcons;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnClickBtnClose;

	private static DelegateBridge __Hotfix0_checkBuy;

	private static DelegateBridge __Hotfix0_OnClickBtnPay;

	private static DelegateBridge __Hotfix0_onButtonStar;

	private static DelegateBridge __Hotfix0_purchaseSuccess;

	private static DelegateBridge __Hotfix0_GetRewardList;

	private static DelegateBridge __Hotfix0_Update;

	private static DelegateBridge __Hotfix0_UpdateCountDown;

	private static DelegateBridge _c__Hotfix0_ctor;

	private void Awake()
	{
	}

	public void Open(PushPackUICtrl ctrl)
	{
	}

	public void Close()
	{
	}

	private void InitIcons(List<Drop_DropModel.DropData> items)
	{
	}

	public void OnLanguageChange()
	{
	}

	private void OnClickBtnClose()
	{
	}

	private bool checkBuy()
	{
		return false;
	}

	private void OnClickBtnPay()
	{
	}

	private void onButtonStar()
	{
	}

	private void purchaseSuccess(CRespInAppPurchase resp, bool success)
	{
	}

	public List<Drop_DropModel.DropData> GetRewardList(Shop_Push data)
	{
		return null;
	}

	private void Update()
	{
	}

	private void UpdateCountDown()
	{
	}
}
