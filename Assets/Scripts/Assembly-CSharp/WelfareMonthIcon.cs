using UnityEngine;

public class WelfareMonthIcon : MainUIButtonBase
{
	public RedNodeCtrl mRedCtrl;

	public ButtonCtrl Button_Reward;

	public DxxText Text_Time;

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
}
