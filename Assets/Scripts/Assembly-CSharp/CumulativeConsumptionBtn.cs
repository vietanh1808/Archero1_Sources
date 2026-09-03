using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CumulativeConsumptionBtn : MainUIButtonBase
{
	public GameObject child;

	public RedNodeCtrl mRedCtrl;

	public ButtonCtrl Button_Reward;

	public Text TimeText;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_IsShow;

	private static DelegateBridge __Hotfix0_GetPriority;

	private static DelegateBridge __Hotfix0_GetTransform;

	private static DelegateBridge __Hotfix0_Show;

	private static DelegateBridge __Hotfix0_UpdateUI;

	private static DelegateBridge __Hotfix0_Update;

	private static DelegateBridge __Hotfix0_GetOpenTime;

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

	private void Show(bool value)
	{
	}

	public new void UpdateUI()
	{
	}

	private void Update()
	{
	}

	public override long GetOpenTime()
	{
		return 0L;
	}
}
