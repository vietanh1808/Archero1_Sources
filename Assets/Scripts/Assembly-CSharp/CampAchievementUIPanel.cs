using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public class CampAchievementUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private Transform parent;

	[SerializeField]
	private CampAchievementProgressItem progressItem;

	[SerializeField]
	private ButtonCtrl close;

	[SerializeField]
	private ButtonCtrl click;

	[SerializeField]
	private GameObject claimedExtraReward;

	[SerializeField]
	private RectTransform progress;

	[SerializeField]
	private DxxText progressText;

	[SerializeField]
	private DxxText tipTitle;

	[SerializeField]
	private Transform tipParent;

	[SerializeField]
	private ButtonCtrl tipClick;

	[SerializeField]
	private Animation chestAni;

	private LocalUnityObjctPool propPool;

	private LocalUnityObjctPool achievementPool;

	private float progressOriginWidth;

	private static DelegateBridge __Hotfix0_get_CampAchievementManager;

	private static DelegateBridge __Hotfix0_get_CampAchievementData;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshExtraItem;

	private static DelegateBridge __Hotfix0_RefreshExtraProgress;

	private static DelegateBridge __Hotfix0_RefreshExtraStatus;

	private static DelegateBridge __Hotfix0_RefreshExtraAni;

	private static DelegateBridge __Hotfix0_ResetExtraAni;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshTipItem;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge __Hotfix0_ClickTip;

	private static DelegateBridge __Hotfix0_Esc;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampAchievementManager CampAchievementManager => null;

	private CampAchievementData CampAchievementData => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void InitObjectPool()
	{
	}

	private void Refresh()
	{
	}

	public void RefreshExtraItem()
	{
	}

	public void RefreshExtraProgress()
	{
	}

	public void RefreshExtraStatus()
	{
	}

	public void RefreshExtraAni()
	{
	}

	private void ResetExtraAni()
	{
	}

	public void RefreshItem()
	{
	}

	public void RefreshTipItem()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void Click()
	{
	}

	private void ClickTip()
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
