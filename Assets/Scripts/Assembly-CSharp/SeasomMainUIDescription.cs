using UnityEngine;
using UnityEngine.UI;

public class SeasomMainUIDescription : MainUIButtonBase
{
	[SerializeField]
	private ButtonCtrl mBtnDesc;

	[SerializeField]
	private Image entranceIcon;

	[SerializeField]
	private GameObject go_Red;

	private void Awake()
	{
	}

	public override RectTransform GetTransform()
	{
		return null;
	}

	public override int GetPriority()
	{
		return 0;
	}

	public override bool IsShow()
	{
		return false;
	}

	public override long GetOpenTime()
	{
		return 0L;
	}

	public void RefreshMode(GameMode mode)
	{
	}
}
