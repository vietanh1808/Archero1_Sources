using UnityEngine;

public class SeasonBPPanelEntrance : MainUIButtonBase
{
	public GameObject child;

	public RedNodeCtrl mRedCtrl;

	public ButtonCtrl Button_Show;

	private void Awake()
	{
	}

	private void OnBtnShowClick()
	{
	}

	public void RefreshRed()
	{
	}

	public override bool isRed()
	{
		return false;
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
}
