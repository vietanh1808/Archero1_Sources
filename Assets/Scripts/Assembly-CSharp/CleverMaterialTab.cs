using System.Collections.Generic;
using GameProtocol;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CleverMaterialTab : MonoBehaviour
{
	private const float Width = 180f;

	[SerializeField]
	private DxxText Text_Title;

	[SerializeField]
	private DxxText Text_Num;

	[SerializeField]
	private DxxText Text_Price_Pay;

	[SerializeField]
	private DxxText Text_GoldBefore_Pay;

	[SerializeField]
	private DxxText Text_Discount;

	[SerializeField]
	private DxxText Text_Value;

	[SerializeField]
	private DxxText Text_CountDown;

	[SerializeField]
	private Image Image_RedLine_Pay;

	[SerializeField]
	private Image Image_Icon;

	[SerializeField]
	private ButtonCtrl Button_Pay;

	[SerializeField]
	private ButtonCtrl Button_Close;

	public ButtonCtrl[] Button_Tabs;

	public GameObject[] Go_Tabs;

	public GameObject[] Go_TabsSelected;

	public GameObject[] Go_TabsUnselected;

	public DxxText[] Text_ButtonTabs;

	public EquipOneCtrl Equip_One;

	public PropOneEquip Prop_One_Equip;

	public PropOneEquip[] propItems;

	public GameObject[] StarObj;

	public DxxText[] StarText;

	private CleverMaterialItemItemData[] pushDataArr;

	private int[] restrictions;

	private int curLevel;

	private HashSet<int> seenLevels;

	private PushPackUICtrl ctrl;

	public VIPFlagItem vipItem;

	public ButtonCtrl Button_Star;

	public DxxText Text_Star;

	private float timer;

	private CleverBuyType type;

	private static DelegateBridge __Hotfix0_get_unlockedLevelMax;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge __Hotfix0_SetUI;

	private static DelegateBridge __Hotfix0_SetTabs;

	private static DelegateBridge __Hotfix0_InitIcons;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnClickBtnClose;

	private static DelegateBridge __Hotfix0_checkBuy;

	private static DelegateBridge __Hotfix0_OnClickBtnPay;

	private static DelegateBridge __Hotfix0_onButtonStar;

	private static DelegateBridge __Hotfix0_purchaseSuccess;

	private static DelegateBridge __Hotfix0_Update;

	private static DelegateBridge __Hotfix0_UpdateCountDown;

	private static DelegateBridge _c__Hotfix0_ctor;

	private int unlockedLevelMax => 0;

	private void Awake()
	{
	}

	public void Open(CleverBuyType type, PushPackUICtrl ctrl)
	{
	}

	public void Close()
	{
	}

	private void SetUI()
	{
	}

	private void SetTabs()
	{
	}

	private void InitIcons()
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

	private void purchaseSuccess(CRespInAppPurchase resp, bool success, CleverMaterialItemItemData pushData)
	{
	}

	private void Update()
	{
	}

	private void UpdateCountDown()
	{
	}
}
