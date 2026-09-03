using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ActNewPlayerUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public DxxText Text_Time;

	private ActSevenDayUIPanel m_ActSevenDayUIPanel;

	private NewRechargeUIPanel m_NewRechargeUIPanel;

	private NewSingleChargeUIPanel m_NewSingleChargeUIPanel;

	private ReChargeDayUIPanel m_ReChargeDayUIPanel;

	private ActSevenChallengeUIPanel m_ActSevenDayChallengeUIPanel;

	private CarnivalShopPanel m_CarnivalShopPanel;

	public Text[] tabTexts;

	public GameObject[] focusTabs;

	public Button[] Button_Tabs;

	public GameObject[] Button_Red;

	public Transform panelParent;

	private int CurTab;

	private static DelegateBridge __Hotfix0_get_actSevenDayUIPanel;

	private static DelegateBridge __Hotfix0_get_newRechargeUIPanel;

	private static DelegateBridge __Hotfix0_get_newSingleChargeUIPanel;

	private static DelegateBridge __Hotfix0_get_reChargeDayUIPanel;

	private static DelegateBridge __Hotfix0_get_actSevenDayChallengeUIPanel;

	private static DelegateBridge __Hotfix0_get_carnivalShopPanel;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_CloseCurPanel;

	private static DelegateBridge __Hotfix0_InitBottom;

	private static DelegateBridge __Hotfix0_SwitchTab;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_onButtonClose;

	private static DelegateBridge __Hotfix0_RefreshRed;

	private static DelegateBridge __Hotfix0_FlyToTab;

	private static DelegateBridge _c__Hotfix0_ctor;

	public ActSevenDayUIPanel actSevenDayUIPanel => null;

	public NewRechargeUIPanel newRechargeUIPanel => null;

	public NewSingleChargeUIPanel newSingleChargeUIPanel => null;

	public ReChargeDayUIPanel reChargeDayUIPanel => null;

	public ActSevenChallengeUIPanel actSevenDayChallengeUIPanel => null;

	public CarnivalShopPanel carnivalShopPanel => null;

	protected override void OnInit()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	private void CloseCurPanel()
	{
	}

	private void InitBottom()
	{
	}

	public void SwitchTab(int tab)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void onButtonClose()
	{
	}

	public void RefreshRed()
	{
	}

	private void FlyToTab()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}

	private void _003C_003ExLuaBaseProxy_OnOpen()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnClose()
	{
	}
}
