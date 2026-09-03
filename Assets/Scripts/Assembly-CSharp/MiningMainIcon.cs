using UnityEngine;
using XLua;

public class MiningMainIcon : MainUIButtonBase
{
	[SerializeField]
	private DxxText countDown;

	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private RedNodeCtrl redCtrl;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_IsShow;

	private static DelegateBridge __Hotfix0_GetPriority;

	private static DelegateBridge __Hotfix0_GetTransform;

	private static DelegateBridge __Hotfix0_GetOpenTime;

	private static DelegateBridge __Hotfix0_freshTime;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_updateUI;

	private static DelegateBridge __Hotfix0_isRed;

	private static DelegateBridge __Hotfix0_onButtonIcon;

	private static DelegateBridge _c__Hotfix0_ctor;

	private void Awake()
	{
	}

	public override bool IsShow()
	{
		return false;
	}

	public override int GetPriority()
	{
		return 0;
	}

	public override RectTransform GetTransform()
	{
		return null;
	}

	public override long GetOpenTime()
	{
		return 0L;
	}

	private void freshTime()
	{
	}

	protected override void OnClose()
	{
	}

	public void updateUI()
	{
	}

	public override bool isRed()
	{
		return false;
	}

	public void onButtonIcon()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnClose()
	{
	}

	private bool _003C_003ExLuaBaseProxy_isRed()
	{
		return false;
	}
}
