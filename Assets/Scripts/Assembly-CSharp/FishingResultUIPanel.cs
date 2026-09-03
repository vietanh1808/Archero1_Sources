using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class FishingResultUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private GameObject successStatus;

	[SerializeField]
	private GameObject failureStatus;

	[SerializeField]
	private DxxText failureDesc;

	[SerializeField]
	private DxxText successDesc;

	[SerializeField]
	private Image fishIcon;

	[SerializeField]
	private DxxText fishQuality;

	[SerializeField]
	private DxxText fishWeight;

	[SerializeField]
	private DxxText fishName;

	[SerializeField]
	private DxxText resultTitle;

	[SerializeField]
	private Transform rewardParent;

	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private DxxText clickBtnName;

	[SerializeField]
	private FishingResultItem resultItem;

	[SerializeField]
	private Image weightBg;

	[SerializeField]
	private ScrollRect scroll;

	[SerializeField]
	private GameObject noneStatus;

	[SerializeField]
	private DxxText noneDesc;

	[SerializeField]
	private FishingResultAni resultAni;

	[SerializeField]
	private Image fishQualityImg;

	private LocalUnityObjctPool pool;

	private FishingResultData data;

	private static DelegateBridge __Hotfix0_get_FishingManager;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge __Hotfix0_ClickClose;

	private static DelegateBridge __Hotfix0_Esc;

	private static DelegateBridge _c__Hotfix0_ctor;

	private FishingManager FishingManager => null;

	private void InitObjectPool()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void Refresh()
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStatus()
	{
	}

	private void Click()
	{
	}

	private void ClickClose()
	{
	}

	private void Esc()
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

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}
}
