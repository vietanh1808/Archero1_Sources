using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class MiningActUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText Text_Title;

	[SerializeField]
	private DxxText Text_CountDown;

	[SerializeField]
	private ButtonCtrl Button_Close;

	[SerializeField]
	private ButtonCtrl Button_Info;

	[SerializeField]
	private ButtonCtrl Button_Shop;

	[SerializeField]
	private DxxText Text_Shop;

	[SerializeField]
	private ButtonCtrl Button_Gift;

	[SerializeField]
	private DxxText Text_Gift;

	[SerializeField]
	private ButtonCtrl Button_PropA;

	[SerializeField]
	private DxxText Text_PropANum;

	[SerializeField]
	private GameObject BuyFlagA;

	[SerializeField]
	private ButtonCtrl Button_PropB;

	[SerializeField]
	private DxxText Text_PropBNum;

	[SerializeField]
	private GameObject BuyFlagB;

	[SerializeField]
	private DxxImage Image_SelectedB;

	[SerializeField]
	private ButtonCtrl Button_PropC;

	[SerializeField]
	private DxxText Text_PropCNum;

	[SerializeField]
	private GameObject BuyFlagC;

	[SerializeField]
	private DxxImage Image_SelectedC;

	[SerializeField]
	private ButtonCtrl Button_Task;

	[SerializeField]
	private DxxText Text_Task;

	[SerializeField]
	private MiningPlay miningPlayPanel;

	public MiningDepthBoxUI depthBoxUI;

	public GameObject PopRewardWindow;

	public RectTransform PopContainer;

	public GameObject cpPopItem;

	public GameObject RedPoint_Task;

	public GameObject RedPoint_Gift;

	public GameObject RedPoint_Shop;

	public GameObject Mask;

	public Toggle to_CleanCache;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnGetEvent;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_onButtonClose;

	private static DelegateBridge __Hotfix0_onButtonInfo;

	private static DelegateBridge __Hotfix0_Esc;

	private static DelegateBridge __Hotfix0_onButtonClickA;

	private static DelegateBridge __Hotfix0_onButtonQuickBuy;

	private static DelegateBridge __Hotfix0_onButtonClickB;

	private static DelegateBridge __Hotfix0_onButtonClickC;

	private static DelegateBridge __Hotfix0_onButtonShop;

	private static DelegateBridge __Hotfix0_onButtonGift;

	private static DelegateBridge __Hotfix0_onButtonTask;

	private static DelegateBridge __Hotfix0_initUI;

	private static DelegateBridge __Hotfix0_freshTime;

	private static DelegateBridge __Hotfix0_freshItems;

	private static DelegateBridge __Hotfix0_RefreshPropA;

	private static DelegateBridge __Hotfix0_RefreshPropB;

	private static DelegateBridge __Hotfix0_RefreshPropC;

	private static DelegateBridge __Hotfix0_freshRedPoint;

	private static DelegateBridge __Hotfix0_showPopReward;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void onButtonClose()
	{
	}

	private void onButtonInfo()
	{
	}

	private void Esc()
	{
	}

	private void onButtonClickA()
	{
	}

	public void onButtonQuickBuy(int type)
	{
	}

	private void onButtonClickB()
	{
	}

	private void onButtonClickC()
	{
	}

	private void onButtonShop()
	{
	}

	private void onButtonGift()
	{
	}

	private void onButtonTask()
	{
	}

	private void initUI()
	{
	}

	private void freshTime()
	{
	}

	private void freshItems()
	{
	}

	public void RefreshPropA()
	{
	}

	public void RefreshPropB()
	{
	}

	public void RefreshPropC()
	{
	}

	private void freshRedPoint()
	{
	}

	public void showPopReward(MiningDepthBoxShowData mdbsd)
	{
	}

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnOpen()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnClose()
	{
	}

	private object _003C_003ExLuaBaseProxy_OnGetEvent(string P0)
	{
		return null;
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}
}
