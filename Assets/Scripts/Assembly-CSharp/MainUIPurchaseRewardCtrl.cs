using Dxx.Util;
using UnityEngine;

public class MainUIPurchaseRewardCtrl : MainUIButtonBase
{
	public GameObject child;

	public ButtonCtrl mButton;

	public RedNodeCtrl mRedCtrl;

	public GameObject effect;

	public DxxText Text_Time;

	private SequencePool mSeqPool;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public new void UpdateUI()
	{
	}

	private void Show(bool value)
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

	public override void OnLanguageChange()
	{
	}

	public override long GetOpenTime()
	{
		return 0L;
	}
}
