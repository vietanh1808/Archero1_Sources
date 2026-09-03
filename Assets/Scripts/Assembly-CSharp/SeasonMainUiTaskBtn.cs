using UnityEngine;

public class SeasonMainUiTaskBtn : MainUIButtonBase
{
	public GameObject child;

	public RedNodeCtrl mRedCtrl;

	public ButtonCtrl Button_Reward;

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

	public new void UpdateUI()
	{
	}

	public override long GetOpenTime()
	{
		return 0L;
	}
}
