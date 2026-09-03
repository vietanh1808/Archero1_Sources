using System.Collections.Generic;
using GameProtocol;
using UnityEngine;

public class GamePlayActivityOne_Normal : GamePlayActivityOneCtrl
{
	public const string guideKey = "DailyPlayGuide";

	public ButtonCtrl buttonCharge;

	public ButtonCtrl buttonEnterBattle;

	public DxxText textLastTime;

	public DxxText textCharge;

	public GameObject buttonMask;

	public GoldTextCtrl costText;

	public DxxText textDebug;

	public GameObject NewFlag;

	[SerializeField]
	private RectTransform mScrollRect;

	[SerializeField]
	private ButtonCtrl sweep;

	[SerializeField]
	private DxxText sweepName;

	protected GameObject newObj;

	private List<int> sweepTypes => null;

	protected override void RefreshData()
	{
	}

	private bool CheatPlayDaily()
	{
		return false;
	}

	protected virtual void RequestSweep()
	{
	}

	public void OnClickEnterWrapper()
	{
	}

	protected virtual void OnClickEnter()
	{
	}

	protected bool IsNeedCheckRes()
	{
		return false;
	}

	protected void OnCheckFinish(string groupName, bool ifFinish, int downloadCount, int downloadSize, List<string> downloadList)
	{
	}

	protected virtual int GetKeyCost()
	{
		return 0;
	}

	protected void EnterGame()
	{
	}

	protected virtual void OnEnterGame()
	{
	}

	protected virtual CDailyPlay GetPacket(int dailyId, ushort type = 0)
	{
		return null;
	}

	private void ReqDailyDataAndPlay(int dailyId)
	{
	}

	private void SendTakeOffTime(int dailyId)
	{
	}

	private void OnClickCharge()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void RefreshLastTimeText()
	{
	}

	private void RefreshDebugInfo()
	{
	}
}
