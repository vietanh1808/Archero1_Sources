using UnityEngine;

public class MainUIPlayerCtrl : MainUIButtonBase
{
	public HeadItem headItem;

	public WindowButtonCtrl Button_Player;

	public RedNodeCtrl redNodeCtrl;

	private void Awake()
	{
	}

	public new void UpdateUI()
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

	private void setting()
	{
	}

	public void freshRedPoint()
	{
	}

	public override long GetOpenTime()
	{
		return 0L;
	}
}
