using UnityEngine;

public class MainUIMenuCtrl : MainUIButtonBase
{
	public GameObject loader;

	public RedNodeOneCtrl redNodeCtrl;

	public ButtonCtrl Button_Menu;

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

	public void setMailRedNode()
	{
	}

	public override long GetOpenTime()
	{
		return 0L;
	}
}
