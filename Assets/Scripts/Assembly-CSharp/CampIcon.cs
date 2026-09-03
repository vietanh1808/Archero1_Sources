using System;
using Dxx.Addressable;
using UnityEngine;
using XLua;

public class CampIcon : MainUIButtonBase
{
	public GameObject child;

	public RedNodeCtrl mRedCtrl;

	public ButtonCtrl Button_Reward;

	public GameObject effect;

	private bool canclick;

	public GameObject TimeBG;

	public DxxText Text_Time;

	private long showTime;

	private int m_nResDownloadState;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_OnClickBtn;

	private static DelegateBridge __Hotfix0_ShowDownloadWindow;

	private static DelegateBridge __Hotfix0_Show;

	private static DelegateBridge __Hotfix0_UpdateUI;

	private static DelegateBridge __Hotfix0_GetPriority;

	private static DelegateBridge __Hotfix0_GetTransform;

	private static DelegateBridge __Hotfix0_IsShow;

	private static DelegateBridge __Hotfix0_GetOpenTime;

	private static DelegateBridge __Hotfix0_UpdateTime;

	private static DelegateBridge __Hotfix0_isRed;

	private static DelegateBridge _c__Hotfix0_ctor;

	private void Awake()
	{
	}

	public void Open()
	{
	}

	private void OnClickBtn()
	{
	}

	private void ShowDownloadWindow(FunctionalModule module, Sprite icon, long cd, Func<FunctionalModule, float> process, Action endCb = null)
	{
	}

	private void Show(bool value)
	{
	}

	public new void UpdateUI()
	{
	}

	public override int GetPriority()
	{
		return 0;
	}

	public override RectTransform GetTransform()
	{
		return null;
	}

	public override bool IsShow()
	{
		return false;
	}

	public override long GetOpenTime()
	{
		return 0L;
	}

	private void UpdateTime()
	{
	}

	public override bool isRed()
	{
		return false;
	}

	private bool _003C_003ExLuaBaseProxy_isRed()
	{
		return false;
	}
}
