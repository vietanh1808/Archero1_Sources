using UnityEngine;
using XLua;

public class HalloweenIcon : MainUIButtonBase
{
	public RedNodeCtrl mRedCtrl;

	public ButtonCtrl Button_Reward;

	public DxxText Text_Time;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_OnClickBtn;

	private static DelegateBridge __Hotfix0_Show;

	private static DelegateBridge __Hotfix0_UpdateUI;

	private static DelegateBridge __Hotfix0_GetPriority;

	private static DelegateBridge __Hotfix0_GetTransform;

	private static DelegateBridge __Hotfix0_IsShow;

	private static DelegateBridge __Hotfix0_GetOpenTime;

	private static DelegateBridge __Hotfix0_isRed;

	private static DelegateBridge __Hotfix0_freshTime;

	private static DelegateBridge _c__Hotfix0_ctor;

	private void Awake()
	{
	}

	private void OnClickBtn()
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

	public override bool isRed()
	{
		return false;
	}

	private void freshTime()
	{
	}

	private bool _003C_003ExLuaBaseProxy_isRed()
	{
		return false;
	}
}
