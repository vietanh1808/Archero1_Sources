using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class EquipCombineUICtrl : MediatorCtrlBase
{
	public EquipCombineCtrl combineCtrl;

	public EquipMeltDownCtrl meltDownCtrl;

	public EquipBreakDownController breakDownCtrl;

	private bool EquipCombineInitFlag;

	private bool EquipMeltDownInitFlag;

	private bool EquipBreakDownInitFlag;

	private LocalUnityObjctPool mEquipOnePool;

	public Button combineButton;

	public Button meltButton;

	public Button breakButton;

	public GameObject combineFocus;

	public GameObject meltFocus;

	public GameObject breakFocus;

	public GameObject meltLocker;

	public DxxText combineText;

	public DxxText meltText;

	public DxxText breakText;

	public GameObject redNode;

	public DxxText combineText1;

	public DxxText meltText1;

	public DxxText breakText1;

	[SerializeField]
	private ScrollRect scrollRect;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnScroll;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnGetEvent;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnButtonTab;

	private static DelegateBridge __Hotfix0_openCombine;

	private static DelegateBridge __Hotfix0_openMeltDown;

	private static DelegateBridge __Hotfix0_openBreakDown;

	private static DelegateBridge __Hotfix0_openCastUI;

	private static DelegateBridge __Hotfix0_checkMeltLocker;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override void OnInit()
	{
	}

	public void OnScroll(Vector2 pos)
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

	public void OnButtonTab(int tab)
	{
	}

	private void openCombine()
	{
	}

	private void openMeltDown()
	{
	}

	private void openBreakDown()
	{
	}

	private void openCastUI()
	{
	}

	private void checkMeltLocker()
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
