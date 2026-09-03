using UnityEngine;

public class PVEExchangeIcon : MainUIButtonBase
{
	public ButtonCtrl Button_Reward;

	public DxxText Text_Time;

	public GameObject Locker;

	private long showTime;

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

	private void UpdateTime()
	{
	}

	public override long GetOpenTime()
	{
		return 0L;
	}
}
