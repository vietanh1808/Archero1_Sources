using UnityEngine;

public class MainUIMailCtrl : MainUIButtonBase
{
	public GameObject child;

	public ButtonCtrl Button_Mail;

	public RedNodeCtrl mRedCtrl;

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

	private void Show(bool value)
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

	public override long GetOpenTime()
	{
		return 0L;
	}
}
