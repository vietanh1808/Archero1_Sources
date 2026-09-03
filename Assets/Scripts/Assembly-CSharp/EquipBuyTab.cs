using System.Collections.Generic;
using GameProtocol;
using TableTool;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class EquipBuyTab : MonoBehaviour
{
	public const int PriceType_Diamond = 2;

	public const int PriceType_Money = 3;

	private const float Width = 180f;

	public DxxText Text_Title;

	public DxxText Text_New;

	public DxxText Text_Price_Pay;

	public DxxText Text_GoldBefore_Pay;

	public DxxText Text_CountDown;

	public GoldTextCtrl Text_Price_Diamond;

	public GoldTextCtrl Text_PriceBefore_Diamond;

	public DxxText Text_Discount;

	public DxxText Text_Value;

	public Image Image_RedLine_Pay;

	public Image Image_RedLine_Diamond;

	public Image Image_BG;

	public Image Image_Light;

	public ButtonCtrl Button_Pay;

	public ButtonCtrl Button_Diamond;

	public ButtonCtrl Button_Close;

	public ButtonCtrl[] Button_Tabs;

	public GameObject[] Go_Tabs;

	public GameObject[] Go_TabsSelected;

	public GameObject[] Go_TabsUnselected;

	public DxxText[] Text_ButtonTabs;

	public GameObject[] StarObj;

	public DxxText[] StarText;

	public GameObject DiscountNode;

	public PropOneEquip[] rewardEquipCtrls;

	private Shop_Push pushData;

	private int pushId;

	private int pushBaseEquipId;

	private int discount;

	private int buyType;

	private Drop_DropModel.DropData[] rewardEquips;

	private LocalSave.EquipOne finalEquip;

	private int _curLevel;

	private List<int> curIds;

	private int[] curTypes;

	private int[] curNums;

	private string curPrice;

	private int curPriceType;

	private HashSet<int> seenLevels;

	private PushPackUICtrl ctrl;

	public VIPFlagItem vipItem;

	public ButtonCtrl Button_Star;

	public DxxText Text_Star;

	private float timer;

	private static DelegateBridge __Hotfix0_get_finalEquipId;

	private static DelegateBridge __Hotfix0_get_unlockedLevelMax;

	private static DelegateBridge __Hotfix0_get_curLevel;

	private static DelegateBridge __Hotfix0_set_curLevel;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge __Hotfix0_Track;

	private static DelegateBridge __Hotfix0_SetUI;

	private static DelegateBridge __Hotfix0_SetTabs;

	private static DelegateBridge __Hotfix0_InitIcon;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnClickBtnClose;

	private static DelegateBridge __Hotfix0_OnClickBtnDiamond;

	private static DelegateBridge __Hotfix0_checkBuy;

	private static DelegateBridge __Hotfix0_OnClickBtnPay;

	private static DelegateBridge __Hotfix0_onButtonStar;

	private static DelegateBridge __Hotfix0_purchaseSuccess;

	private static DelegateBridge __Hotfix0_GetCurrencyList;

	private static DelegateBridge __Hotfix0_IfEquipBuyUpgradeValid;

	private static DelegateBridge __Hotfix0_Update;

	private static DelegateBridge __Hotfix0_UpdateCountDown;

	private static DelegateBridge _c__Hotfix0_ctor;

	private int finalEquipId => 0;

	private int unlockedLevelMax => 0;

	private int curLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public void Open(PushPackUICtrl ctrl)
	{
	}

	public void Close()
	{
	}

	private void Track()
	{
	}

	private void SetUI()
	{
	}

	private void SetTabs()
	{
	}

	private void InitIcon()
	{
	}

	public void OnLanguageChange()
	{
	}

	private void OnClickBtnClose()
	{
	}

	private void OnClickBtnDiamond()
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

	private List<Drop_DropModel.DropData> GetCurrencyList()
	{
		return null;
	}

	private bool IfEquipBuyUpgradeValid(int baseEquip, int finalEquip)
	{
		return false;
	}

	private void Update()
	{
	}

	private void UpdateCountDown()
	{
	}
}
