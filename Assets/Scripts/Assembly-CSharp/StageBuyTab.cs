using System.Collections.Generic;
using GameProtocol;
using TableTool;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public sealed class StageBuyTab : MonoBehaviour
{
	private const float Width = 180f;

	public DxxText Text_Title;

	public DxxText Text_New;

	public DxxText Text_Price;

	public DxxText Text_Value;

	public DxxText Text_GoldBefore;

	public DxxText Text_CountDown;

	public Image Image_RedLine;

	public Image Image_BG;

	public Image Image_Light;

	public ButtonCtrl Button_Click;

	public ButtonCtrl Button_Close;

	public GameObject RewardParent;

	public GameObject ItemOne;

	public GameObject ItemAdd;

	public static List<Color> mLightColors;

	public ButtonCtrl Button_Star;

	public DxxText Text_Star;

	private LocalUnityObjctPool mPool;

	private List<ShopOneStageDiscountOneCtrl> mList;

	private List<Drop_DropModel.DropData> rewards;

	private string mID;

	private bool ifFirstBuy;

	private Current_purchaseItem validItem;

	private CleverBuyType type;

	private PushPackUICtrl ctrl;

	private float timer;

	private static DelegateBridge __Hotfix0_GetColor;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnClickBtnClose;

	private static DelegateBridge __Hotfix0_checkBuy;

	private static DelegateBridge __Hotfix0_OnClickBtnBuy;

	private static DelegateBridge __Hotfix0_onButtonStar;

	private static DelegateBridge __Hotfix0_purchaseSuccess;

	private static DelegateBridge __Hotfix0_Update;

	private static DelegateBridge __Hotfix0_UpdateCountDown;

	private static DelegateBridge _c__Hotfix0_ctor;

	public static Color GetColor(int id)
	{
		return default;
	}

	private void Awake()
	{
	}

	public void Open(CleverBuyType type, PushPackUICtrl ctrl)
	{
	}

	public void Close()
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

	private void OnClickBtnBuy()
	{
	}

	private void onButtonStar()
	{
	}

	private void purchaseSuccess(CRespInAppPurchase resp, bool success)
	{
	}

	private void Update()
	{
	}

	private void UpdateCountDown()
	{
	}
}
