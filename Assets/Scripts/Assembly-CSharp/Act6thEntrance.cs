using UnityEngine;

public class Act6thEntrance : MainUIButtonBase
{
	public GameObject child;

	public RedNodeCtrl mRedCtrl;

	public ButtonCtrl Button_Reward;

	public DxxText Text_Time;

	private long showTime;

	private Act6thManager AMgr => null;

	private void Awake()
	{
	}

	public void Open()
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

	private void UpdateTime()
	{
	}

	public override bool isRed()
	{
		return false;
	}
}
