using Dxx.Util;
using UnityEngine;

public class MainUIActivityCtrl : MainUIButtonBase
{
	private static bool isShowDailyFirstRed;

	private int gotoTab;

	public GameObject child;

	public WindowButtonCtrl mButton;

	public RedNodeCtrl mRedCtrl;

	public GameObject bgLimit;

	public GameObject bgNormal;

	public DxxText txt_Name;

	private SequencePool mSeqPool;

	private string str;

	private long last;

	private long currenttime;

	private long starttime;

	private long endtime;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public new void UpdateUI()
	{
	}

	private void UpdateRed()
	{
	}

	private void UpdateForce()
	{
	}

	private void show(bool value)
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

	public override long GetOpenTime()
	{
		return 0L;
	}

	public override bool isRed()
	{
		return false;
	}

	public override void OnLanguageChange()
	{
	}
}
