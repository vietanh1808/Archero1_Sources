using UnityEngine;

public class SeasomMainUITopic : MainUIButtonBase
{
	[SerializeField]
	private ButtonCtrl mBtnTopic;

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
}
