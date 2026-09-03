using UnityEngine;

public class SeasonMainUIGift : MainUIButtonBase
{
	[SerializeField]
	private ButtonCtrl mBtnDesc;

	[SerializeField]
	private RedNodeCtrl mRedCtrl;

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

	public override void UpdateUI()
	{
	}
}
