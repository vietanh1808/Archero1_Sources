using UnityEngine;

public class SeasonMainUIHardTaskBtn : MainUIButtonBase
{
	public GameObject child;

	public RedNodeCtrl mRedCtrl;

	public ButtonCtrl Button_Reward;

	public Animation ani_Box;

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

	public void Show()
	{
	}

	public new void UpdateUI()
	{
	}

	public override long GetOpenTime()
	{
		return 0L;
	}
}
